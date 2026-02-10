using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;
using CapaNegocio;
using CapaPresentacion.Plantillas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormsRevisiones
{
    public partial class FormReporteEnRevision : UIReportes
    {
        public event Action<Requisicion> SelecionarRequisicion;
        public FormReporteEnRevision()
        {
            InitializeComponent();
            //Load += (s, e) => CargarComponentes();
            Load += (s, e) => CargarRequisiciones();
        }
        private void CargarRequisiciones()
        {
            dataView.DataSource = LogicaNegocio.TablaRequisiciones();
            dataView.CellDoubleClick += DoubleClick;
        }

        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
        }


        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Requisicion requisicion = new Requisicion()
                {
                    IdRequisicion = dataView.Rows[e.RowIndex].Cells["IdRequisicion"].Value.ToString()
                };
                SelecionarRequisicion?.Invoke(requisicion);
                this.Close();
            }
        }
        private void BuCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
