using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;
using CapaEntidades.StatePattern;
using CapaNegocio;
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


namespace CapaPresentacion.FormsRevisiones
{
    public partial class FormRevision : UIregistro
    {
        public FormRevision()
        {
            InitializeComponent();
            CargarDatosEstados();
        }
        private void CargarDatosEstados()
        {
            cbxEstadosRequisicion.Text = "Elegir estado";
            cbxEstadosRequisicion.Items.Add("Aprobada");
            cbxEstadosRequisicion.Items.Add("Rechazada");
            cbxEstadosRequisicion.Items.Add("Cancelada");
        }
        private void BuCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarText()
        {
            textbIdRequisicion.Text = string.Empty;
            textbDepartamento.Text = string.Empty;
            textbTotalRequisicion.Text = string.Empty;
            textbEstadoRequisicion.Text = string.Empty;
            textbIdEmpleado.Text = string.Empty;
            textbNombre.Text = string.Empty;
            textbFechaCreacion.Text = string.Empty;
            cbxEstadosRequisicion.Text = "Elegir estado";

        }
        private void BuBuscarRequisicion_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] encontral = new DataRow[0];
                FormReporteEnRevision reporteEnRevision = new FormReporteEnRevision(1);
                reporteEnRevision.SelecionarRequisicion += (requisicion) =>
                {
                    encontral = LogicaNegocio.TablaRequisiciones()
                    .Select($"IdRequisicion = '{requisicion.IdRequisicion}'");

                    DataRow requisicionEnRevixsion = encontral[0];
                    if (requisicionEnRevixsion["Estado"].ToString() == "Creada")
                    {
                        RequisicionEstado requisicionEnRevision = new RequisicionEstado();
                        requisicionEnRevision.EnRevision();

                        IRequisicionesBuilder requisicionesBuilder = new RequisicionBuilder();
                        Requisicion requisicionCambioEstado = requisicionesBuilder
                            .ConIdRequisicion(requisicion.IdRequisicion)
                            .ConFechaModificacion(DateTime.Today)
                            .ConEstado(requisicionEnRevision)
                            .Builder();

                        LogicaRequisicionNegocio.ActualizarEstadoRequisicion(requisicionCambioEstado);
                    }

                    encontral = LogicaNegocio.TablaRequisiciones()
                    .Select($"IdRequisicion = '{requisicion.IdRequisicion}'");
                };
                reporteEnRevision.ShowDialog();

                if (encontral.Length > 0)
                {
                    DataRow requisicion = encontral[0];
                    textbIdRequisicion.Text = requisicion["IdRequisicion"].ToString();
                    textbIdEmpleado.Text = requisicion["IdEmpleado"].ToString();
                    textbNombre.Text = requisicion["Empleado"].ToString();
                    textbDepartamento.Text = requisicion["Departamento"].ToString();
                    textbTotalRequisicion.Text = requisicion["Total"].ToString();
                    textbFechaCreacion.Text = requisicion["FechaCreacion"].ToString();
                    textbEstadoRequisicion.Text = requisicion["Estado"].ToString();
                }
            }
            catch (Exception errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al realizar la operacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BuCargarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdRequisicion.Text))
                {
                    throw new ControlExcepciones("Debe seleccionar una requisición primero para cargar su detalle");
                }

                var listaDetalle = LogicaRequisicionNegocio.ListaRequisicionDetalle();
                

                var detalle = listaDetalle.Select($"IdRequisicion = '{textbIdRequisicion.Text}'");
                viewDetalleRequisicion.DataSource = detalle.CopyToDataTable();
            }
            catch (ControlExcepciones errores)
            {
                MessageBox.Show($"{errores.Message}", "Error de busqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al realizar la operacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambioFinalEstado(RequisicionEstado estado)
        {
            IRequisicionesBuilder requisicionesBuilder = new RequisicionBuilder();
            Requisicion requisicionCambioEstado = requisicionesBuilder
                .ConIdRequisicion(textbIdRequisicion.Text)
                .ConFechaModificacion(DateTime.Today)
                .ConEstado(estado)
                .Builder();

            LogicaRequisicionNegocio.ActualizarEstadoRequisicion(requisicionCambioEstado);
            textbEstadoRequisicion.Text = estado.estado.Estado;
        }

        private void BuGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbEstadoRequisicion.Text != "En Revisión")
                {
                    throw new ControlExcepciones($"No se puede {cbxEstadosRequisicion.Text} " +
                        $"la requisición porque esta ya fue {textbEstadoRequisicion.Text}");
                }

                var mensaje = MessageBox.Show($"Desea {cbxEstadosRequisicion.Text} esta requisición?", $"{cbxEstadosRequisicion.Text} de requisición",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(mensaje == DialogResult.Yes)
                {
                    RequisicionEstado requisicionEstadoFinal = new RequisicionEstado();
                    requisicionEstadoFinal.EnRevision();
                    switch (cbxEstadosRequisicion.Text)
                    {
                        case "Aprobada":
                            {
                                requisicionEstadoFinal.Aprobada();
                                CambioFinalEstado(requisicionEstadoFinal);
                            }
                            break;

                        case "Rechazada":
                            {
                                requisicionEstadoFinal.Rechazada();
                                CambioFinalEstado(requisicionEstadoFinal);
                            }
                            break;

                        case "Cancelada":
                            {
                                requisicionEstadoFinal.Cancelada();
                                CambioFinalEstado(requisicionEstadoFinal);
                            }
                            break;

                        default:
                            break;
                    }

                    MessageBox.Show($"Requisición {cbxEstadosRequisicion.Text} con exito!", "Operación completada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarText();
                }
                
            }
            catch (ControlExcepciones errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al realizar la operacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al realizar la operacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
