using CapaEntidades.BuilderPattern.DetalleRequisicion;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos.Controller
{
    public class DatosDetalleRequisicion
    {

        public static DataTable TablaDetalleRequisicion()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("pa_CargarDetalleRequisicion", acceso);
                DataTable TablaDetalleRequisicion = new DataTable();
                adapter.Fill(TablaDetalleRequisicion);
                return TablaDetalleRequisicion;
            }         
        }
        public static void AgregarDetalleRequisicion(DetalleRequisicion detalle)
        {
            int resultado;
            using(SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("pa_AgregarDetalleRequisicion", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdRequisicion", detalle.Requisicion.IdRequisicion);
                comando.Parameters.AddWithValue("@IdProducto", detalle.Productos.IdProducto);
                comando.Parameters.AddWithValue("@Producto", detalle.Productos.Producto);
                comando.Parameters.AddWithValue("@Precio", detalle.Productos.Precio);
                comando.Parameters.AddWithValue("@ITBIS", detalle.Productos.ITBIS);
                comando.Parameters.AddWithValue("@Cantidad", detalle.Items.Cantidad);
                comando.Parameters.AddWithValue("@PrecioCantidad", detalle.Items.PrecioCantidad);
                comando.Parameters.AddWithValue("@SubTotal", detalle.Items.SubTotal);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
