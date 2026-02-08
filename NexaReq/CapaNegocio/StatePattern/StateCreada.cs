using CapaEntidades;
namespace CapaNegocio.StatePattern
{
    public class StateCreada : IStateRequisicion
    {
        public int Id => 1;

        public string Estado => "Creada";
        public void Creada(RequisicionEstado estado) { }
        public void EnRevision(RequisicionEstado estado) 
        {
            estado.TransicionEstado(new StateEnRevision());
        }
        public void Aprodaba(RequisicionEstado estado) { }
        public void Cancelada(RequisicionEstado estado) { }
        public void Rechazada(RequisicionEstado estado) { }
     
    }
}
