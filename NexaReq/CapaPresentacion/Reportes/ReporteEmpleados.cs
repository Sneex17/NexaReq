using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using CapaPresentacion.Reportes;

namespace CapaPresentacion.Reportes
{
    public partial class ReporteEmpleados : UIReportes
    {
        public event Action<Empleado> SelecionarEmpleado;
        public ReporteEmpleados()
        {
            InitializeComponent();
            Load += (s, e) => CargarComponentes();
            Load += (s, e) => CargarEmpleados();
            
        }

        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            BuGeneralReportes.Visible = false;
            BuCerrarVentana.Visible = false;
            cbxCamposDeBuscar.Items.Add("ID EMPLEADO");
            cbxCamposDeBuscar.Items.Add("NOMBRE");
            cbxCamposDeBuscar.Items.Add("DEPARTAMENTO");
            cbxCamposDeBuscar.Items.Add("CARGO");
            cbxCamposDeBuscar.Items.Add("CORREO");
        }

        private void CargarEmpleados()
        {
            dataView.DataSource = LogicaNegocio.TablaEmpleados();
            dataView.CellDoubleClick += DoubleClick;
            textbFiltro.TextChanged += TextChanges;
        }

        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Empleado empleado = new Empleado()
                {
                    IdEmpleado = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["IdEmpleado"].Value)
                };
                SelecionarEmpleado?.Invoke(empleado);
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
                CargarEmpleados();
            }
            else
            {
                var listaTodo = LogicaNegocio.TablaEmpleados();
                DataRow[] nuevaLista;
                switch (cbxCamposDeBuscar.Text)
                {
                    case "ID EMPLEADO":
                        {
                            nuevaLista = listaTodo.Select($"CONVERT(IdEmpleado, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "NOMBRE":
                        {
                            nuevaLista = listaTodo.Select($"Nombre LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "DEPARTAMENTO":
                        {
                            nuevaLista = listaTodo.Select($"Departamento LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "CARGO":
                        {
                            nuevaLista = listaTodo.Select($"Cargo LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "CORREO":
                        {
                            nuevaLista = listaTodo.Select($"Correo LIKE '%{textbFiltro.Text}%'");
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
