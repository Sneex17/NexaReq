using CapaEntidades;
using CapaEntidades.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.BuilderPattern.Requisiciones
{
    public class Requisicion
    {
        public static List<Requisicion> listaRequisicion = new List<Requisicion>();
        public string IdRequisicion { get; set; }
        public Empleado Empleado { get; set; }
        public Departamento Departamento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public decimal Total { get; set; }
        public RequisicionEstado Estado { get; set; }
    }

}
