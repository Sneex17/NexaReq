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
using CapaPresentacion.Reportes;
using CapaEntidades;

namespace CapaPresentacion.Reportes
{
    public partial class ReporteProductos : UIReportes
    {
        public event Action<Productos> SelecionarProducto;
        public ReporteProductos()
        {
            InitializeComponent();
            Load += (s, e) => CargarComponentes();
            Load += (s, e) => CargarProductos();
        }

        private void CargarComponentes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CargarProductos()
        {
            dataView.DataSource = LogicaNegocio.TablaProductos();
            dataView.CellDoubleClick += DoubleClick;
        }

        private void DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Productos producto = new Productos()
                {
                    IdProducto = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["IdProducto"].Value)
                };
                SelecionarProducto?.Invoke(producto);
                this.Close();
            }
        }
    }
}
