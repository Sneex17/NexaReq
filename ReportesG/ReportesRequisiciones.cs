using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesG
{
    public partial class ReportesRequisiciones : Form
    {
        public ReportesRequisiciones()
        {
            InitializeComponent();
        }

        private void ReportesRequisiciones_Load(object sender, EventArgs e)
        {

            string ruta = @"C:\Users\xrami\OneDrive\Escritorio\NexaReq\ReportesG\ReporteRequisicion.rdlc";
            this.reportViewer.RefreshReport();
            reportViewer.LocalReport.ReportPath = ruta;
            GestionNexaReqDBDataSetViewRaprobadas ds = new GestionNexaReqDBDataSetViewRaprobadas();

            GestionNexaReqDBDataSetViewRaprobadasTableAdapters
                .ListaRequisicionesAprobadasTableAdapter ta =
                new GestionNexaReqDBDataSetViewRaprobadasTableAdapters
                .ListaRequisicionesAprobadasTableAdapter();

            ta.Fill(ds.ListaRequisicionesAprobadas);


            ReportDataSource rds = new ReportDataSource("DsAprobado", ds.ListaRequisicionesAprobadas.DefaultView);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();

        }
    }
}
