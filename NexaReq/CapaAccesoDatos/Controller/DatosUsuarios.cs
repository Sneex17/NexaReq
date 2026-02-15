using CapaEntidades.EntidadesA;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Controller
{
    public class DatosUsuarios
    {
        public static bool ValidacionUsuario(Usuarios usuarios)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("pa_ValidacioUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Username", usuarios.Username);
                comando.Parameters.AddWithValue("@PasswordHash", usuarios.PasswordHash);
                resultado = (int)comando.ExecuteScalar();

                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static int UsuarioActual(Usuarios usuarios)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int IdRol = 0;
                SqlCommand comando = new SqlCommand("pa_UsuarioActual", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Username", usuarios.Username);
                comando.Parameters.AddWithValue("@PasswordHash", usuarios.PasswordHash);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    IdRol = (int)reader.GetInt32(4);
                }
                reader.Close();
                return IdRol;
            }
        }
    }

}
