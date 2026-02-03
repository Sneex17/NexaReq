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

namespace CapaPresentacion.FormsSolicitudes
{
    public partial class FormSolicitud : UIregistro
    {
        public FormSolicitud()
        {
            InitializeComponent();
        }

        private void BuBuscarEmpleados_Click(object sender, EventArgs e)
        {
            DataRow[] encontral = new DataRow[0];
            ReporteEmpleados empleados = new ReporteEmpleados();
            empleados.SelecionarEmpleado += (empleado) =>
            {
                encontral = LogicaNegocio.TablaEmpleados()
                .Select($"IdEmpleado = '{empleado.IdEmpleado}'");
            };
            empleados.ShowDialog();

            if (encontral.Length > 0)
            {
                DataRow empleado = encontral[0];
                textbIdEmpleado.Text = empleado["IdEmpleado"].ToString();
                textbNombre.Text = empleado["Nombre"].ToString();
                textbDepartamento.Text = empleado["Departamento"].ToString();
            }
        }

        private void BuBuscarProducto_Click(object sender, EventArgs e)
        {
            DataRow[] encontral = new DataRow[0];
            ReporteProductos productos = new ReporteProductos();
            productos.SelecionarProducto += (producto) =>
            {
                encontral = LogicaNegocio.TablaProductos()
                .Select($"IdProducto = '{producto.IdProducto}'");
            };
            productos.ShowDialog();

            if(encontral.Length > 0)
            {
                DataRow producto = encontral[0];
                textbIdProducto.Text = producto["IdProducto"].ToString();
                textbProducto.Text = producto["Producto"].ToString();
                textbPrecioUnit.Text = producto["Precio"].ToString();
                textbITBIS.Text = producto["ITBIS"].ToString();
            }
        }
    }
}
