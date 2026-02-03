namespace CapaEntidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int IdCargo { get; set; }
        public string Correo { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
