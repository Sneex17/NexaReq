using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;

namespace CapaEntidades.BuilderPattern.DetalleRequisicion
{
    public interface IDetalleRequisicion
    {
        IDetalleRequisicion ConRequisicion(Requisicion requisicion);
        IDetalleRequisicion ConProducto(Productos productos);
        IDetalleRequisicion ConItem(Items items);
        DetalleRequisicion Builder();
    }
}
