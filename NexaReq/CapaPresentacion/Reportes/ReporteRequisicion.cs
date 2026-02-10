using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Plantillas;

namespace CapaPresentacion.Reportes
{
    public partial class ReporteRequisicion : UIregistro
    {
        public ReporteRequisicion()
        {
            InitializeComponent();
            Load += (s, e) => CargarComponentes();
        }

        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BuCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
