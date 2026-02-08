namespace CapaNegocio
{
    public class ControlExcepciones : Exception
    {
        public ControlExcepciones() { }
        public ControlExcepciones(string mensaje) : base(mensaje) { }
    }
}
