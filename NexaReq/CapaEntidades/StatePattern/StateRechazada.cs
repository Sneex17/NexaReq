using CapaEntidades;
namespace CapaEntidades.StatePattern
{
    public class StateRechazada : IStateRequisicion
    {
        public int Id => 4;
        public string Estado => "Rechazada";
        public void Creada(RequisicionEstado estado) { }
        public void EnRevision(RequisicionEstado estado) { }
        public void Aprodaba(RequisicionEstado estado) { }
        public void Cancelada(RequisicionEstado estado) { }
        public void Rechazada(RequisicionEstado estado) { }
    }
}
