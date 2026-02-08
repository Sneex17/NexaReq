using CapaEntidades;
namespace CapaEntidades.StatePattern
{
    public class StateCancelada : IStateRequisicion
    {
        public int Id => 5;

        public string Estado => "Cancelada";

        public void Creada(RequisicionEstado estado) { }
        public void EnRevision(RequisicionEstado estado) { }
        public void Aprodaba(RequisicionEstado estado) { }
        public void Cancelada(RequisicionEstado estado) { }
        public void Rechazada(RequisicionEstado estado) { }
    }
}
