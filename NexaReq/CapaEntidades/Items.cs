namespace CapaEntidades
{
    public class Items : Productos
    {
        public static List<Items> listaProducto = new List<Items>();
        public int Cantidad { get; set; }
        public decimal PrecioCantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
