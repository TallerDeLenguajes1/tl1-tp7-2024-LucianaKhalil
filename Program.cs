using EspacioCalculadora;
using Empleados;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Hola, Mundo!");

        Calculadora MiCalculadora = new Calculadora();
        int opcion;
        double valor, dato = 0;
        string operaciones = ""; // hay que inicializar string

        do
        {
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            // Leer la operación
            if (int.TryParse(Console.ReadLine(), out int operacion))
            {
                Console.WriteLine("Ingrese el valor para la operación:");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    switch (operacion)
                    {
                        case 1:
                            operaciones = "suma";
                            MiCalculadora.sumar(valor);
                            break;
                        case 2:
                            operaciones = "resta";
                            MiCalculadora.restar(valor);
                            break;
                        case 3:
                            operaciones = "multiplicacion";
                            MiCalculadora.multiplicar(valor);
                            break;
                        case 4:
                            operaciones = "division";
                            MiCalculadora.dividir(valor);
                            break;
                        default:
                            Console.WriteLine("Operación no válida");
                            break;
                    }

                    // Imprimir el resultado
                    Console.WriteLine($"La {operaciones} de {dato} y {valor} es igual a: {MiCalculadora.Resultado}");
                }
                else
                {
                    Console.WriteLine("Valor ingresado no válido.");
                }
            }
            else
            {
                Console.WriteLine("Operación no válida.");
            }

            Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
        } while (int.TryParse(Console.ReadLine(), out opcion) && opcion == 1);

        double Resultado = MiCalculadora.Resultado;
        Console.WriteLine($"Resultado final: {Resultado}");

        // Crear una instancia de Empleado y llamar al método MostrarDetalles dentro del método Main
        Empleado empleado = new Empleado("John", "Doe", new DateTime(1990, 5, 15), 'S', DateTime.Now, 350000.0, Cargos.Administrativo);
        empleado.MostrarDetalles();

      
    }
}
