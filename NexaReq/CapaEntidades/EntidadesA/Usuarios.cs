using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.EntidadesA
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime UltimoAcceso { get; set; }
    }

}
