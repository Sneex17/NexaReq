using CapaEntidades;
using CapaEntidades.EntidadesA;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        }

        private void CargarRequisiciones()
        {
            dataView.DataSource = LogicaNegocio.TablaRequisiciones();
            dataView.CellDoubleClick += DoubleClick;
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
