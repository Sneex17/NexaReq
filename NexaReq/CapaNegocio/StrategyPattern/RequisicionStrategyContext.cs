namespace CapaNegocio.StrategyPattern
{
    public class RequisicionStrategyContext
    { 
        private IStrategyItbis _itbis;

        public void SelecionarItbis(IStrategyItbis itbis) => _itbis = itbis;

        public decimal ObtenerItbis(decimal precio)
        {
            if(_itbis == null)
            {
                throw new ArgumentNullException();
            }
            return _itbis.ItbisProducto(precio);
        }
    }
}
