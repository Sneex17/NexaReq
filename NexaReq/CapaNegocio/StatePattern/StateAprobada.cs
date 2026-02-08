using CapaEntidades;
namespace CapaNegocio.StatePattern
{
    public class StateAprobada : IStateRequisicion
    {
        public int Id => 3;
        public string Estado => "Aprobada";
        public void Creada(RequisicionEstado estado) { }
        public void EnRevision(RequisicionEstado estado) { }
        public void Aprodaba(RequisicionEstado estado) { }
        public void Cancelada(RequisicionEstado estado) { }
        public void Rechazada(RequisicionEstado estado) { }
    }
}
