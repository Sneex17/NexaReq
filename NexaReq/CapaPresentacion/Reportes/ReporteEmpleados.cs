using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void CargarEmpleados()
        {
            dataView.DataSource = LogicaNegocio.TablaEmpleados();
            dataView.CellDoubleClick += DoubleClick;
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
    }
}
