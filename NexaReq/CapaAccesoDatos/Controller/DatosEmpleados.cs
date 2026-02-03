using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos.Controller
{
    public class DatosEmpleados
    { 
        public static DataTable ListaEmpleados()
        { 
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("pa_VerTablaEmpleados", acceso);
                DataTable TablaEmpleados = new DataTable();
                adapter.Fill(TablaEmpleados);
                return TablaEmpleados;
            }            
        }  
    }
}
