namespace CapaNegocio.StrategyPattern
{
    public class ItbisEightTeen : IStrategyItbis
    {
        public decimal ItbisProducto(decimal precio)
        {
            double p = Convert.ToDouble(precio);
            p = p * 0.18;
            precio = Convert.ToDecimal(p);
            return precio;
        }
    }


}
