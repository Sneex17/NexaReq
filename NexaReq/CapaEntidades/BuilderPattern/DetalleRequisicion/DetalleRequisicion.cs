using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.BuilderPattern.DetalleRequisicion
{
    public class DetalleRequisicion
    {
        public int IdDetalleRequisicion { get; set; }
        public Requisicion Requisicion { get; set; }
        public Productos Productos {  get; set; }
        public Items Items { get; set; }
    }
}
