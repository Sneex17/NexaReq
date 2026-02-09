using CapaEntidades;
using CapaEntidades.StatePattern;

namespace CapaEntidades.BuilderPattern.Requisiciones
{
    public interface IRequisicionesBuilder
    {
        IRequisicionesBuilder ConIdRequisicion(string id);
        IRequisicionesBuilder ConEmpleado(Empleado empleado);
        IRequisicionesBuilder ConDepartamento(Departamento departamento);
        IRequisicionesBuilder ConTotal(decimal total);
        IRequisicionesBuilder ConFechaCreacion(DateTime fechacreacion);
        IRequisicionesBuilder ConFechaModificacion(DateTime fechamodificacion);
        IRequisicionesBuilder ConEstado(RequisicionEstado estado);
        Requisicion Builder();
    }

}
