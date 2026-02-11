using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using CapaPresentacion.Reportes;
using CapaEntidades;

namespace CapaPresentacion.Reportes
{
    public partial class ReporteProductos : UIReportes
    {
        public event Action<Productos> SelecionarProducto;
        public ReporteProductos()
        {
            InitializeComponent();
            Load += (s, e) => CargarComponentes();
            Load += (s, e) => CargarProductos();
        }

        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
            BuGeneralReportes.Visible = false;
            BuCerrarVentana.Visible = false;
            cbxCamposDeBuscar.Items.Add("ID PRODUCTO");
            cbxCamposDeBuscar.Items.Add("PRODUCTO");
            cbxCamposDeBuscar.Items.Add("CATEGORIA");
            cbxCamposDeBuscar.Items.Add("PRECIO");
        }

        private void CargarProductos()
        {
            dataView.DataSource = LogicaNegocio.TablaProductos();
            dataView.CellDoubleClick += DoubleClick;
            textbFiltro.TextChanged += TextChanges;
        }

        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Productos producto = new Productos()
                {
                    IdProducto = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["IdProducto"].Value)
                };
                SelecionarProducto?.Invoke(producto);
                this.Close();
            }
        }

        private void Filtro(DataRow[] nuevaLista)
        {
            if (nuevaLista.Length > 0)
            {
                dataView.DataSource = nuevaLista.CopyToDataTable();
            }
            else
            {
                dataView.DataSource = null;
            }
        }
        private void TextChanges(object sender, EventArgs e)
        {
           if(string.IsNullOrWhiteSpace(textbFiltro.Text))
           {
                CargarProductos();
           }
           else
           {
                var listaTodo = LogicaNegocio.TablaProductos();
                DataRow[] nuevaLista;
                switch (cbxCamposDeBuscar.Text)
                {
                    case "ID PRODUCTO":
                        {
                            nuevaLista = listaTodo.Select($"CONVERT(IdProducto, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "PRODUCTO":
                        {
                            nuevaLista = listaTodo.Select($"Producto LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "CATEGORIA":
                        {
                            nuevaLista = listaTodo.Select($"Categoria LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "PRECIO":
                        {
                            nuevaLista = listaTodo.Select($"CONVERT(Precio, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                            
                        break;
            
                    default:
                        break;      
                }
            }
        }
    }
}
