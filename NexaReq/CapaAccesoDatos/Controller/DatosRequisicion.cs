using CapaEntidades.BuilderPattern;
using System.Data;
using CapaEntidades.BuilderPattern.Requisiciones;
using Microsoft.Data.SqlClient;


namespace CapaAccesoDatos.Controller
{
    public class DatosRequisicion
    {

        public static int Requisiciones()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("pa_CantidadIdentity", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                resultado = (int)comando.ExecuteScalar();
                return resultado;
            }  
        }

        public static void AgregarRequisicion(Requisicion requisicion)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("", requisicion.IdRequisicion);
                comando.Parameters.AddWithValue("", requisicion.Empleado.IdEmpleado);
                comando.Parameters.AddWithValue("", requisicion.Departamento.IdDepartamento);
                comando.Parameters.AddWithValue("", requisicion.Total);
                comando.Parameters.AddWithValue("", requisicion.Estado.IdEstado);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
