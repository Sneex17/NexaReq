using CapaEntidades;
using CapaNegocio.StatePattern;

namespace CapaNegocio.BuilderPattern.Requisiciones
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
