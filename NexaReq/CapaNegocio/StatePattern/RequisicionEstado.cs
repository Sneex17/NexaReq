using CapaNegocio;
namespace CapaNegocio.StatePattern;

public class RequisicionEstado
{
    public IStateRequisicion estado {  get; private set; }

    public RequisicionEstado()
    {
        estado = new StateCreada();
    }

    public void TransicionEstado(IStateRequisicion NewState)
    {
        estado = NewState;
    }

    public void EnRevision() => estado.EnRevision(this);
    public void Aprobada() => estado.Aprodaba(this);
    public void Cancelada() => estado.Cancelada(this);
    public void Rechazada() => estado.Rechazada(this);


}
