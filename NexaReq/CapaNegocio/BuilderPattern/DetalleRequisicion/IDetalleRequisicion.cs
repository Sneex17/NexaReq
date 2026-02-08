using CapaEntidades;
using CapaNegocio.BuilderPattern.Requisiciones;

namespace CapaNegocio.BuilderPattern.DetalleRequisicion
{
    public interface IDetalleRequisicion
    {
        IDetalleRequisicion ConRequisicion(Requisicion requisicion);
        IDetalleRequisicion ConIdProducto(Productos productos);
        IDetalleRequisicion ConProducto(Productos productos);
        IDetalleRequisicion ConPrecio(Productos productos);
        IDetalleRequisicion ConITBIS(Productos productos);
        IDetalleRequisicion ConCantidad(Items items);
        IDetalleRequisicion ConPrecioCantidad(Items items);
        IDetalleRequisicion ConSubTotal(Items items);
        DetalleRequisicion Builder();
    }
}
