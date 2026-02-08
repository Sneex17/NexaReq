using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaEntidades.StatePattern
{
    public interface IStateRequisicion
    {
        void Creada(RequisicionEstado estado);
        void EnRevision(RequisicionEstado estado);
        void Aprodaba(RequisicionEstado estado);
        void Rechazada(RequisicionEstado estado);
        void Cancelada(RequisicionEstado estado);
        int Id { get; }
        string Estado { get; }
    }
}
