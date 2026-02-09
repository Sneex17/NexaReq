using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;
namespace CapaAccesoDatos.Controller
{
    public class DatosDepartamento
    {
        public static List<Departamento> listadepartamentos = new List<Departamento>();
        public static List<Departamento> Departamentos()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("pa_ListaDepartamentos", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listadepartamentos.Add(new Departamento
                    {
                        IdDepartamento = reader.GetInt32(0),
                        NombreDepartamento = reader.GetString(1)
                    });
                }
                reader.Close();
            }
            return listadepartamentos;
        }
    }
}
