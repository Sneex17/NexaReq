using CapaAccesoDatos;
using CapaAccesoDatos.Controller;
using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;
using CapaEntidades.EntidadesA;
using CapaEntidades.BuilderPattern.DetalleRequisicion;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable TablaEmpleados()
        {
            return DatosEmpleados.ListaEmpleados();
        }

        public static DataTable TablaProductos()
        {
            return DatosProductos.ListaProductos();
        }

        public static string PrecioPorCantidad(decimal precio, decimal itbis, int cantidad)
        {
            decimal subTotal = (precio + itbis) * cantidad;
            return Convert.ToString(subTotal);
        }

        public static decimal Preciocantidad(decimal precio, int cantidad)
        {
            decimal precioCantidad = precio * cantidad;
            return precioCantidad;
        }

        public static bool AgregarMasCanntidadProducto(int idProducto, int NewCantidad,
            decimal NewPreciocantidad, decimal NewITBIS, decimal NewSubTotal)
        {
            var dato = Items.listaProducto.Find(L => L.IdProducto == idProducto);
            if(dato == null)
            {
                return false;
            }
            else
            {
                dato.Cantidad += NewCantidad;
                dato.PrecioCantidad += NewPreciocantidad;
                dato.ITBIS += NewITBIS;
                dato.SubTotal += NewSubTotal;
                return true;
            }
        }

        public static decimal CalculoTotal()
        {
            decimal Total = 0;
            foreach (var subToal in Items.listaProducto)
            {
                Total += subToal.SubTotal;
            }
            return Total;
        }

        public static List<Departamento> ListaDepartamentos()
        {
            return DatosDepartamento.Departamentos();
        }
        public static string GeneralIdRequisicion()
        {
            int count = DatosRequisicion.Requisiciones();
            string idRequisicion = $"RSC-NR{count + 1}";
            return idRequisicion;
        }

        public static void InsertarRequisicion(Requisicion requisicion)
        {
            DatosRequisicion.AgregarRequisicion(requisicion);
        }

        public static void InsertarDetalleRequisicion(DetalleRequisicion detalleRequisicion)
        {
            DatosDetalleRequisicion.AgregarDetalleRequisicion(detalleRequisicion);
        }

        public static DataTable TablaRequisiciones()
        {
            return DatosRequisicion.ListaRequisiciones();   
        }
    }
}
