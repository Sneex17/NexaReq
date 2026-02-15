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

            string ruta = @"C:\Users\xrami\OneDrive\Escritorio\NexaReq\ReportesG\ra\ReportesG\ReporteRequisicionA.rdlc";
            this.reportViewer.RefreshReport();
            reportViewer.LocalReport.ReportPath = ruta;
            GestionNexaReqDBDataSetRA dsRA = new GestionNexaReqDBDataSetRA();

            GestionNexaReqDBDataSetRATableAdapters
                .vwRequisicionAprobadaTableAdapter L =
                new GestionNexaReqDBDataSetRATableAdapters
                .vwRequisicionAprobadaTableAdapter();

            L.Fill(dsRA.vwRequisicionAprobada);

            ReportDataSource rds = new ReportDataSource("DsRequisicionA", dsRA.vwRequisicionAprobada.DefaultView);


            GestionNexaReqDBDataSetDRA dsDRA = new GestionNexaReqDBDataSetDRA();

            GestionNexaReqDBDataSetDRATableAdapters
                .vwDetalleRequisicionAprobadaTableAdapter M =
                new GestionNexaReqDBDataSetDRATableAdapters
                .vwDetalleRequisicionAprobadaTableAdapter();

            M.Fill(dsDRA.vwDetalleRequisicionAprobada);

            ReportDataSource rds2 = new ReportDataSource("DsDetalleRA", dsDRA.vwDetalleRequisicionAprobada.DefaultView);



            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.DataSources.Add(rds2);
            reportViewer.RefreshReport();

        }
    }
}
