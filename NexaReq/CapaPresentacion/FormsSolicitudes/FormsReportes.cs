using CapaEntidades;
using CapaEntidades.EntidadesA;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion.FormsSolicitudes
{
    public partial class FormsReportes : UIReportes
    {
        string idRquisicio, EstadoRequisicion;


        public FormsReportes()
        {
            InitializeComponent();
            Load += (s, e) => CargarRequisiciones();
            Load += (s, e) => CargarComponentes();
         }

        private void CargarRequisiciones()
        {
            dataView.DataSource = LogicaNegocio.TablaRequisiciones();
            dataView.CellDoubleClick += DoubleClick;
            textbFiltro.TextChanged += TextChanges;
        }
        private void CargarComponentes()
        {
            cbxCamposDeBuscar.Items.Add("ID REQUISICIÓN");
            cbxCamposDeBuscar.Items.Add("ID EMPLEADO");
            cbxCamposDeBuscar.Items.Add("EMPLEADO");
            cbxCamposDeBuscar.Items.Add("DEPARTAMENTO");
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
                            nuevaLista = listaTodo.Select($"CONVERT(IdRequisicion, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "ID EMPLEADO":
                        {
                            nuevaLista = listaTodo.Select($"CONVERT(IdEmpleado, 'System.String') LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "EMPLEADO":
                        {
                            nuevaLista = listaTodo.Select($"Empleado LIKE '%{textbFiltro.Text}%'");
                            Filtro(nuevaLista);
                        }
                        break;

                    case "DEPARTAMENTO":
                        {
                            nuevaLista = listaTodo.Select($"Departamento LIKE '%{textbFiltro.Text}%'");
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
            try
            {
                if (string.IsNullOrWhiteSpace(idRquisicio))
                {
                    throw new ControlExcepciones("Debe seleccionar una requisición para ver el reporte");
                }

                if(EstadoRequisicion != "Aprobada")
                {
                    throw new ControlExcepciones($"la requisición {idRquisicio} esta {EstadoRequisicion}\nSolo se puede ver el reporte de las requisiciones que han sedo aprobadas");
                }

                Process.Start(@"C:\Users\xrami\OneDrive\Escritorio\NexaReq\ReportesG\ra\ReportesG\bin\Debug\ReportesG.exe");

                //@"C:\Users\xrami\OneDrive\Escritorio\NexaReq\ReportesG\ra\ReportesG\bin\Debug\ReportesG.exe"

                //@"C:\Users\xrami\OneDrive\Escritorio\NexaReq\ReportesG\bin\Debug\ReportesG.exe"
            }
            catch (ControlExcepciones errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al general el reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errores)
            {
                MessageBox.Show($"{errores.Message}", "Errror al general el reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idRquisicio = dataView.Rows[e.RowIndex].Cells["IdRequisicion"].Value.ToString();
            EstadoRequisicion = dataView.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            if(EstadoRequisicion == "Aprobada")
            {
                LogicaRequisicionNegocio.AgregarReporte(idRquisicio);
            }
            
        }
    }
}
