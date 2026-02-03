using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public sealed class ConexionBD
    {
        private static ConexionBD? _instancia;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private ConexionBD()
        {
            _connectionString =
                @"Data Source=DESKTOP-5F1MSU0;
                  Initial Catalog=GestionNexaReqDB;
                  User ID=sa;
                  Password=sa;
                  TrustServerCertificate=True;";
        }

        /// <summary>
        /// Método para instancial la conexión
        /// </summary>
        public static ConexionBD Instancia
        {
            get
            {
                lock (_lock)
                {
                    return _instancia ??= new ConexionBD();
                }
            }
        }
        /// <summary>
        /// Método para obtener la conexión
        /// </summary>
        /// <returns>una conexión</returns>
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }
    }

}
