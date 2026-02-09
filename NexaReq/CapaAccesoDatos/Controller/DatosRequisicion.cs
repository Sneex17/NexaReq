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
                SqlCommand comando = new SqlCommand("pa_AgregarRequisicion", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdRequisicion", requisicion.IdRequisicion);
                comando.Parameters.AddWithValue("@IdEmpleado", requisicion.Empleado.IdEmpleado);
                comando.Parameters.AddWithValue("@IdDepartamento", requisicion.Departamento.IdDepartamento);
                comando.Parameters.AddWithValue("@FechaCreacion", requisicion.FechaCreacion);
                comando.Parameters.AddWithValue("@FechaModificacion", requisicion.FechaModificacion);
                comando.Parameters.AddWithValue("@Total", requisicion.Total);
                comando.Parameters.AddWithValue("@IdEstado", requisicion.Estado.estado.Id);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
