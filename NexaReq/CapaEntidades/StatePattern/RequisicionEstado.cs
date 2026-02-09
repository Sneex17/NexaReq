
namespace CapaEntidades.StatePattern;

public class RequisicionEstado
{
    public int IdEstado { get; set; }
    public string Estado { get; set; }
    public IStateRequisicion estado {  get; private set; }

    public RequisicionEstado()
    {
        estado = new StateCreada();
    }

    public void TransicionEstado(IStateRequisicion NewState)
    {
        estado = NewState;
    }
    public void Creada() => estado.Creada(this);
    public void EnRevision() => estado.EnRevision(this);
    public void Aprobada() => estado.Aprodaba(this);
    public void Cancelada() => estado.Cancelada(this);
    public void Rechazada() => estado.Rechazada(this);


}
