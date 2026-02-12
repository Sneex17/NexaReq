using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormsRevisiones
{
    public partial class FormReporteEnRevision : UIReportes
    {
        public event Action<Requisicion> SelecionarRequisicion;
        public FormReporteEnRevision(int? L)
        {
            InitializeComponent();
            Load += (s, e) => CargarRequisiciones();

            if (L != null) { Load += (s, e) => CargarComponentes(); }
            CargarComboFilto();


        }
        private void CargarRequisiciones()
        {
            dataView.DataSource = LogicaNegocio.TablaRequisiciones();
            dataView.CellDoubleClick += DoubleClick;
            textbFiltro.TextChanged += TextChanges;
        }
        private void CargarComboFilto()
        {
            cbxCamposDeBuscar.Items.Add("ID REQUISICIÓN");
            cbxCamposDeBuscar.Items.Add("ID EMPLEADO");
            cbxCamposDeBuscar.Items.Add("DEPARTAMENTO");
            cbxCamposDeBuscar.Items.Add("ESTADO");
        }
        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
        }


        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Requisicion requisicion = new Requisicion()
                {
                    IdRequisicion = dataView.Rows[e.RowIndex].Cells["IdRequisicion"].Value.ToString()
                };
                SelecionarRequisicion?.Invoke(requisicion);
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
            if (string.IsNullOrWhiteSpace(textbFiltro.Text))
            {
                CargarRequisiciones();
            }
            else
            {
                var listaTodo = LogicaNegocio.TablaRequisiciones();
                DataRow[] nuevaLista;
                switch (cbxCamposDeBuscar.Text)
                {
                    case "ID REQUISICIÓN":
                        {
                            nuevaLista = listaTodo.Select($"IdRequisicion LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "ID EMPLEADO":
                        {
                            nuevaLista = listaTodo.Select($"CONVERT(IdEmpleado, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "DEPARTAMENTO":
                        {
                            nuevaLista = listaTodo.Select($"Departamento LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "ESTADO":
                        {
                            nuevaLista = listaTodo.Select($"Estado LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    default:
                        break;


                }
            }
        }

        private void BuCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuGeneralReportes_Click(object sender, EventArgs e)
        {
            

        }
    }
}
