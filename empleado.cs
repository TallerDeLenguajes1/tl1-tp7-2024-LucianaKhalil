namespace Empleados{

    public enum Cargos// enum se utiliza para definir un tipo de datos enumerado, un tipo de datos que consiste en un conjunto de constantes con nombre, llamadas enumeradores.
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
    class Empleado{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    public int CalcularAntiguedad()
        {
            TimeSpan antiguedad = DateTime.Now - FechaIngreso;
            return (int)(antiguedad.TotalDays / 365);
        }

     // Constructora
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }

        // Método para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Estado Civil: {EstadoCivil}");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Sueldo Básico: {SueldoBasico}");
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }
}


