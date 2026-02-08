using CapaEntidades;
using CapaEntidades.StatePattern;

namespace CapaEntidades.BuilderPattern.Requisiciones
{
    public interface IRequisicionesBuilder
    {
        IRequisicionesBuilder ConIdRequisicion(int id);
        IRequisicionesBuilder ConEmpleado(Empleado empleado);
        IRequisicionesBuilder ConDepartamento(Departamento departamento);
        IRequisicionesBuilder ConTotal(decimal total);
        IRequisicionesBuilder ConEstado(RequisicionEstado estado);
        Requisicion Builder();
    }

}
