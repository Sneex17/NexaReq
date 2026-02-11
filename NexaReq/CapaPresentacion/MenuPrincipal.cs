using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.FormsSolicitudes;
using CapaPresentacion.FormsRevisiones;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            SubmenuOff();
        }

        private void SubmenuOff()
        {
            panelSmSolicitudes.Visible = false;
            panelSmRequisiciones.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSmRequisiciones.Visible == true) panelSmRequisiciones.Visible = false;
            if (panelSmSolicitudes.Visible == true) panelSmSolicitudes.Visible = false;
        }
        private void ControlSubmen(Panel panelSubmenuActivo)
        {
            if (panelSubmenuActivo.Visible == false)
            {
                HideSubMenu();
                panelSubmenuActivo.Visible = true;
            }
            else
            {
                panelSubmenuActivo.Visible = false;
            }
        }

        /// <summary>
        /// Variable para los formularios hijos
        /// </summary>
        private Form FormActivo = null;
        /// <summary>
        /// Metodo para abrir los formularios en un contenedor
        /// </summary>
        /// <param name="FormChild">Recibe un formulario hijo</param>
        private void OpenForms(Form FormChild)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FormChild;
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            FormChild.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(FormChild);
            panelContainer.Tag = FormChild;
            FormChild.BringToFront();
            FormChild.Show();
        }

        private void BuSolicitudes_Click(object sender, EventArgs e)
        {
            ControlSubmen(panelSmSolicitudes);
        }

        private void BuRequisiciones_Click(object sender, EventArgs e)
        {
            ControlSubmen(panelSmRequisiciones);
        }
        private void BuSalirMenu_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void BuSolicitud_Click(object sender, EventArgs e)
        {
            OpenForms(new FormSolicitud());
        }

        private void BuReporteSolicitud_Click(object sender, EventArgs e)
        {
            OpenForms(new FormsReportes());
        }

        private void BuRevisiones_Click(object sender, EventArgs e)
        {
            OpenForms(new FormRevision());
        }

        private void BuReportesPendientes_Click(object sender, EventArgs e)
        {
            OpenForms(new FormReporteEnRevision(null));
        }
    }
}
