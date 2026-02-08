namespace CapaNegocio.StrategyPattern
{
    public class ItbisSixTeen : IStrategyItbis
    {
        public decimal ItbisProducto(decimal precio)
        {
            double p = Convert.ToDouble(precio);
            p = p * 0.16;
            precio = Convert.ToDecimal(p);
            return precio;
        }
    }


}
