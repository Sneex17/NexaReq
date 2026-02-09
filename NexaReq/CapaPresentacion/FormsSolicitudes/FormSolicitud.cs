using CapaEntidades;
using CapaEntidades.BuilderPattern.DetalleRequisicion;
using CapaEntidades.BuilderPattern.Requisiciones;
using CapaEntidades.StatePattern;
using CapaNegocio;
using CapaNegocio.StrategyPattern;
using CapaPresentacion.Plantillas;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion.FormsSolicitudes
{
    public partial class FormSolicitud : UIregistro
    {
        RequisicionStrategyContext strategyContext = new RequisicionStrategyContext();
        private RequisicionEstado requisicionEstado;
        string precioUnito, precioSubtotal;
        public FormSolicitud()
        {
            InitializeComponent();
            requisicionEstado = new RequisicionEstado();
            CargarItbis();
        }

        private void CargarItbis()
        {
            cbxSeleccionITBIS.Items.Add("Sin ITBIS");
            cbxSeleccionITBIS.Items.Add("ITBIS 16%");
            cbxSeleccionITBIS.Items.Add("ITBIS 18%");
        }
        private void BuBuscarEmpleados_Click(object sender, EventArgs e)
        {
            DataRow[] encontral = new DataRow[0];
            ReporteEmpleados empleados = new ReporteEmpleados();
            empleados.SelecionarEmpleado += (empleado) =>
            {
                encontral = LogicaNegocio.TablaEmpleados()
                .Select($"IdEmpleado = '{empleado.IdEmpleado}'");
            };
            empleados.ShowDialog();

            if (encontral.Length > 0)
            {
                DataRow empleado = encontral[0];
                textbIdEmpleado.Text = empleado["IdEmpleado"].ToString();
                textbNombre.Text = empleado["Nombre"].ToString();
                textbDepartamento.Text = empleado["Departamento"].ToString();
            }
        }

        private void BuBuscarProducto_Click(object sender, EventArgs e)
        {
            DataRow[] encontral = new DataRow[0];
            ReporteProductos productos = new ReporteProductos();
            productos.SelecionarProducto += (producto) =>
            {
                encontral = LogicaNegocio.TablaProductos()
                .Select($"IdProducto = '{producto.IdProducto}'");
            };
            productos.ShowDialog();

            if (encontral.Length > 0)
            {
                DataRow producto = encontral[0];
                textbIdProducto.Text = producto["IdProducto"].ToString();
                textbProducto.Text = producto["Producto"].ToString();
                textbPrecioUnit.Text = producto["Precio"].ToString();
                //textbITBIS.Text = producto["ITBIS"].ToString();
                //textbSubTotal.Text = Convert.ToString(
                //    Convert.ToDecimal(textbPrecioUnit.Text) +
                //    Convert.ToDecimal(textbITBIS.Text));
            }
            precioUnito = textbPrecioUnit.Text;
            //precioSubtotal = textbSubTotal.Text;
        }

        private void textbCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textbCantidad.Text == "0")
                {
                    throw new ControlExcepciones("La cantidad debe ser mayor que 0");
                }
                if (string.IsNullOrWhiteSpace(textbCantidad.Text))
                {
                    textbPrecioUnit.Text = precioUnito;
                    textbSubTotal.Text = precioSubtotal;
                }
                else
                {
                    decimal precio = Convert.ToDecimal(textbPrecioUnit.Text);
                    decimal itbis = Convert.ToDecimal(textbITBIS.Text);
                    int cantidad = Convert.ToInt32(textbCantidad.Text);
                    textbSubTotal.Text = LogicaNegocio.PrecioPorCantidad(precio, itbis, cantidad);
                }
            }
            catch (ControlExcepciones errores)
            {
                MessageBox.Show($"{errores.Message}", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errores)
            {
                MessageBox.Show($"{errores.Message}", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuAgregar_Click(object sender, EventArgs e)
        {
            if (Items.listaProducto.Count == 0)
            {
                AgregarItems();
                AgregarListaItems();
                CalcularTotal();
            }
            else
            {
                int idProducto = Convert.ToInt32(textbIdProducto.Text);
                int NewCantidad = Convert.ToInt32(textbCantidad.Text);
                decimal NewPreciocantidad = LogicaNegocio.Preciocantidad(
                        Convert.ToDecimal(textbPrecioUnit.Text), Convert.ToInt32(textbCantidad.Text));
                decimal NewITBIS = Convert.ToDecimal(textbITBIS.Text);
                string SubTotal = LogicaNegocio.PrecioPorCantidad(
                    Convert.ToDecimal(textbPrecioUnit.Text), NewITBIS, NewCantidad);
                decimal NewSubTotal = Convert.ToDecimal(SubTotal);

                var resultado = LogicaNegocio.AgregarMasCanntidadProducto(idProducto, NewCantidad,
                    NewPreciocantidad, NewITBIS, NewSubTotal);

                if (!resultado)
                {
                    AgregarItems();
                    AgregarListaItems();
                    CalcularTotal();
                }
                else
                {
                    AgregarListaItems();
                    CalcularTotal();
                }
            }
        }
        private void AgregarItems()
        {
            Items.listaProducto.Add(new Items
            {
                IdProducto = Convert.ToInt32(textbIdProducto.Text),
                Producto = textbProducto.Text,
                Precio = Convert.ToDecimal(textbPrecioUnit.Text),
                Cantidad = Convert.ToInt32(textbCantidad.Text),
                PrecioCantidad = LogicaNegocio.Preciocantidad(
                        Convert.ToDecimal(textbPrecioUnit.Text), Convert.ToInt32(textbCantidad.Text)),
                ITBIS = Convert.ToDecimal(textbITBIS.Text),
                SubTotal = Convert.ToDecimal(textbSubTotal.Text)
            });
        }
        private void LimpiarCampos()
        {
            textbIdProducto.Text = string.Empty;
            textbProducto.Text = string.Empty;
            textbPrecioUnit.Text = string.Empty;
            textbCantidad.Text = string.Empty;
            textbITBIS.Text = string.Empty;
            textbSubTotal.Text = string.Empty;
            BuAplicarItbis.Enabled = true;
            cbxSeleccionITBIS.Text = "Elegir itbis";
        }
        private void AgregarListaItems()
        {
            dataViewDetalleItems.Rows.Clear();
            foreach (var item in Items.listaProducto)
            {
                dataViewDetalleItems.Rows.Add(new object[]
                {
                        item.IdProducto, item.Producto,
                        item.Precio, item.Cantidad,
                        item.PrecioCantidad, item.ITBIS,
                        item.SubTotal, "Eliminar"
                });
            }
            LimpiarCampos();
        }
        private void CalcularTotal()
        {
            textbTotal.Text = Convert.ToString(LogicaNegocio.CalculoTotal());
        }

        private void ControlITBIS(IStrategyItbis strategy)
        {
            strategyContext.SelecionarItbis(strategy);
            textbITBIS.Text = Convert.ToString(
                strategyContext.ObtenerItbis(Convert.ToDecimal(precioUnito)));
            BuAplicarItbis.Enabled = false;
            textbSubTotal.Text = Convert.ToString(
                Convert.ToDecimal(textbPrecioUnit.Text) +
                Convert.ToDecimal(textbITBIS.Text));
            precioSubtotal = textbSubTotal.Text;
        }
        private void BuAplicarItbis_Click(object sender, EventArgs e)
        {
            switch (cbxSeleccionITBIS.Text)
            {
                case "Sin ITBIS":
                    { ControlITBIS(new SinItbisStrategy()); }
                    break;

                case "ITBIS 16%":
                    { ControlITBIS(new ItbisSixTeen()); }
                    break;

                case "ITBIS 18%":
                    { ControlITBIS(new ItbisEightTeen()); }
                    break;

                default:
                    break;
            }
        }

        private void BuSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataViewDetalleItems.Rows.Count <= 1)
                {
                    throw new ControlExcepciones("Debe de agregar por lo menos 1 producto para realizar la solicitud de compra");
                }
                else
                {
                    var empleado = new Empleado 
                    {
                        IdEmpleado = Convert.ToInt32(textbIdEmpleado.Text),
                        Nombre = textbNombre.Text,
                    };

                    var listaDepartamento = LogicaNegocio.ListaDepartamentos();
                    var Departamento = from L in listaDepartamento
                                         where (L.NombreDepartamento == textbDepartamento.Text)
                                         select new { L.IdDepartamento };

                    int IdDepartamento = 0;
                    foreach (var id in Departamento )
                    {
                        IdDepartamento = id.IdDepartamento;
                    }

                    var departamento = new Departamento
                    { 
                        NombreDepartamento = textbDepartamento.Text,
                        IdDepartamento = IdDepartamento
                    };

                    requisicionEstado.Creada();
                    string idRequisicion = LogicaNegocio.GeneralIdRequisicion();

                    IRequisicionesBuilder requisicionesBuilder = new RequisicionBuilder();
                    Requisicion requisicion = requisicionesBuilder
                        .ConIdRequisicion(idRequisicion)
                        .ConEmpleado(empleado)
                        .ConDepartamento(departamento)
                        .ConTotal(Convert.ToDecimal(textbTotal.Text))
                        .ConFechaCreacion(DateTime.Today)
                        .ConFechaModificacion(DateTime.Today)
                        .ConEstado(requisicionEstado)
                        .Builder();


                    foreach (DataGridViewRow item in dataViewDetalleItems.Rows)
                    {
                        if (item.IsNewRow) continue;
                        var productos = new Productos
                        {
                            IdProducto = Convert.ToInt32(item.Cells[0].Value.ToString()),
                            Producto = item.Cells[1].Value.ToString(),
                            Precio = Convert.ToDecimal(item.Cells[2].Value.ToString()),
                            ITBIS = Convert.ToDecimal(item.Cells[5].Value.ToString())
                        };

                        var items = new Items
                        {
                            Cantidad = Convert.ToInt32(item.Cells[3].Value.ToString()),
                            PrecioCantidad = Convert.ToDecimal(item.Cells[4].Value.ToString()),
                            SubTotal = Convert.ToDecimal(item.Cells[6].Value.ToString())
                        };

                        IDetalleRequisicion detalleRequisicionBuilder = new DetalleRequisicionBuilder();
                        DetalleRequisicion detalle = detalleRequisicionBuilder
                            .ConRequisicion(requisicion)
                            .ConProducto(productos)
                            .ConItem(items)
                            .Builder();

                        MessageBox.Show($"{detalle.Requisicion.IdRequisicion}\n{detalle.Productos.IdProducto}\n" +
                        $"{detalle.Productos.Producto}\n{detalle.Productos.Precio}\n" +
                        $"{detalle.Productos.ITBIS}\n{detalle.Items.Cantidad}\n" +
                        $"{detalle.Items.PrecioCantidad}\n{detalle.Items.SubTotal}", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    MessageBox.Show($"{requisicion.IdRequisicion}\n{requisicion.Empleado.IdEmpleado}\n" +
                        $"{requisicion.Departamento.IdDepartamento}\n{requisicion.Total}\n" +
                        $"{requisicion.Estado.estado.Id}\n", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (ControlExcepciones errores)
            {

                MessageBox.Show($"{errores.Message}", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errores)
            {

                MessageBox.Show($"{errores.Message}", "Cantidad no valida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
