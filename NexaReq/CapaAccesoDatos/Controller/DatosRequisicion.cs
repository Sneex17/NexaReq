using CapaEntidades.BuilderPattern;
using System.Data;
using CapaEntidades.BuilderPattern.Requisiciones;
using Microsoft.Data.SqlClient;


namespace CapaAccesoDatos.Controller
{
    public class DatosRequisicion
    {

        public static DataTable ListaRequisiciones()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("pa_ReporteRequisiciones", acceso);
                DataTable TablaRequisiciones = new DataTable();
                adapter.Fill(TablaRequisiciones);
                return TablaRequisiciones;
            }   
        }
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


        public static void ActualizarRequisicion(Requisicion requisicion)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("pa_ActualizarEstadorequisicion", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdRequisicion", requisicion.IdRequisicion);
                comando.Parameters.AddWithValue("@IdEstado", requisicion.Estado.estado.Id);
                comando.Parameters.AddWithValue("@FechaModificacion", requisicion.FechaModificacion);
                resultado = comando.ExecuteNonQuery();
            }
        }

        public static void ReporteRequisicion(string idRequisicion)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("pa_Reporte", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdRequisicion", idRequisicion);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
