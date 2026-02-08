using CapaEntidades;
using CapaEntidades.StatePattern;

namespace CapaEntidades.BuilderPattern.Requisiciones
{
    public class RequisicionBuilder : IRequisicionesBuilder
    {
        private readonly Requisicion _requisicion = new Requisicion();
        public IRequisicionesBuilder ConIdRequisicion(int id)
        {
            _requisicion.IdRequisicion = id;
            return this;
        }
        public IRequisicionesBuilder ConEmpleado(Empleado empleado)
        {
            _requisicion.Empleado = empleado;
            return this;
        }
        public IRequisicionesBuilder ConDepartamento(Departamento departamento)
        {
            _requisicion.Departamento = departamento;
            return this;
        }
        public IRequisicionesBuilder ConEstado(RequisicionEstado estado)
        {
            _requisicion.Estado = estado;
            return this;
        }
        public IRequisicionesBuilder ConTotal(decimal total)
        {
            _requisicion.Total = total;
            return this;
        }
        public Requisicion Builder()
        {
            return _requisicion;
        }
    }

}
