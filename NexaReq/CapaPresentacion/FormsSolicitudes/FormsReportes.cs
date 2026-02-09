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

namespace CapaPresentacion.FormsSolicitudes
{
    public partial class FormsReportes : UIReportes
    {
        public FormsReportes()
        {
            InitializeComponent();
            Load += (s, e) => CargarRequisiciones();
        }

        private void CargarRequisiciones()
        {
            dataView.DataSource = LogicaNegocio.TablaRequisiciones();
        }

        private void BuCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
