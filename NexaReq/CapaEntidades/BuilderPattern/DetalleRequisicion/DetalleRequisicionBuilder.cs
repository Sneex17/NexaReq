using CapaEntidades;
using CapaEntidades.BuilderPattern.Requisiciones;

namespace CapaEntidades.BuilderPattern.DetalleRequisicion
{
    public class DetalleRequisicionBuilder : IDetalleRequisicion
    {
        private readonly DetalleRequisicion _Detalle = new DetalleRequisicion();
        public IDetalleRequisicion ConRequisicion(Requisicion requisicion)
        {
            _Detalle.Requisicion = requisicion;
            return this;
        }
        public IDetalleRequisicion ConProducto(Productos productos)
        {
            _Detalle.Productos = productos;
            return this;
        }
        public IDetalleRequisicion ConItem(Items items)
        {
            _Detalle.Items = items;
            return this;
        }
        public DetalleRequisicion Builder()
        {
            return _Detalle;
        }
    }
}
