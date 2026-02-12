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

namespace CapaPresentacion.ReportesG
{
    public partial class ReportesGenerales : Form
    {
        public ReportesGenerales()
        {
            InitializeComponent();
        }

        private void ReportesGenerales_Load(object sender, EventArgs e)
        {
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            Controls.Add(reportViewer1);
           
        }
    }
}
