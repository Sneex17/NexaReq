using CapaEntidades;
using CapaNegocio.BuilderPattern.Requisiciones;

namespace CapaNegocio.BuilderPattern.DetalleRequisicion
{
    public class DetalleRequisicionBuilder : IDetalleRequisicion
    {
        private readonly DetalleRequisicion _Detalle = new DetalleRequisicion();
        public IDetalleRequisicion ConRequisicion(Requisicion requisicion)
        {
            _Detalle.Requisicion.IdRequisicion = requisicion.IdRequisicion;
            return this;
        }
        public IDetalleRequisicion ConIdProducto(Productos productos)
        {
            _Detalle.Productos.IdProducto = productos.IdProducto;
            return this;
        }
        public IDetalleRequisicion ConProducto(Productos productos)
        {
            _Detalle.Productos.Producto = productos.Producto;
            return this;
        }
        public IDetalleRequisicion ConPrecio(Productos productos)
        {
            _Detalle.Productos.Precio = productos.Precio;
            return this;
        }
        public IDetalleRequisicion ConCantidad(Items items)
        {
            _Detalle.Items.Cantidad = items.Cantidad;
            return this;
        }
        public IDetalleRequisicion ConPrecioCantidad(Items items)
        {
            _Detalle.Items.PrecioCantidad = items.PrecioCantidad;
            return this;
        }
        public IDetalleRequisicion ConITBIS(Productos productos)
        {
            _Detalle.Productos.ITBIS = productos.ITBIS;
            return this;
        }
        public IDetalleRequisicion ConSubTotal(Items items)
        {
            _Detalle.Items.SubTotal = items.SubTotal;
            return this;
        }
        public DetalleRequisicion Builder()
        {
            return _Detalle;
        }
    }
}
