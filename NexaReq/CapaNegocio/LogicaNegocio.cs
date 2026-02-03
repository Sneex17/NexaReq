using CapaAccesoDatos;
using CapaAccesoDatos.Controller;
using CapaEntidades.EntidadesA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LogicaNegocio
    {
        public static bool ValidarUsario(Usuarios usuarios)
        {
            usuarios.PasswordHash = PasswordSHA256.GetSha256(usuarios.PasswordHash);
            bool resultado = DatosUsuarios.ValidacionUsuario(usuarios);
            //UsuariosController.ListaUsuarios(usuarios);
            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
