using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos.Controller
{
    public class DatosProductos
    {
        public static DataTable ListaProductos()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("pa_VerTablaProductos", acceso);
                DataTable TablaProductos = new DataTable();
                adapter.Fill(TablaProductos);
                return TablaProductos;
            }
        }
    }
}
