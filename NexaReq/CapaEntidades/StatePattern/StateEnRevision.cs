using CapaEntidades;
namespace CapaEntidades.StatePattern
{
    public class StateEnRevision : IStateRequisicion
    {
        public int Id => 2;

        public string Estado => "En Revisión";

        public void Creada(RequisicionEstado estado) { }
        public void EnRevision(RequisicionEstado estado) { }
        public void Aprodaba(RequisicionEstado estado)
        {
            estado.TransicionEstado(new StateAprobada());
        }
        public void Cancelada(RequisicionEstado estado)
        {
            estado.TransicionEstado(new StateCancelada());
        }
        public void Rechazada(RequisicionEstado estado)
        {
            estado.TransicionEstado(new StateRechazada());
        }
    }
}
