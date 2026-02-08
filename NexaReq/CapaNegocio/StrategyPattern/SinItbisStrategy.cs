namespace CapaNegocio.StrategyPattern
{
    public class SinItbisStrategy : IStrategyItbis
    {
        public decimal ItbisProducto(decimal precio)
        {
            return precio * 0;
        }
    }


}
