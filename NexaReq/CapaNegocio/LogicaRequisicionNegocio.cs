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
    public class LogicaRequisicionNegocio
    {
        public static DataTable ListaRequisicionDetalle()
        {
            return DatosDetalleRequisicion.TablaDetalleRequisicion();
        }

        public static void ActualizarEstadoRequisicion(Requisicion requisicion)
        {
            DatosRequisicion.ActualizarRequisicion(requisicion);
        }

        public static void AgregarReporte(string idRequisicion)
        {
            DatosRequisicion.ReporteRequisicion(idRequisicion);
        }
    }
}
