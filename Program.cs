// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Console.WriteLine("Hello, World!");

Calculadora MiCalculadora=new Calculadora();

do
{
    
    Console.WriteLine("Seleccione la operacion que desea realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");

    int operacion=int.Parse(Console.ReadLine());
        switch (operacion)
        {
            case 1: 
                MiCalculadora.sumar(5);
                break;
            case 2: 
                MiCalculadora.restar(2);
                break;
            case 3: 
                MiCalculadora.multiplicar(3);
                break;
            case 4: 
                if(dato!=0){
                MiCalculadora.dividir(2);
                }else{
                    Console.WriteLine("No se puede dividir por 0");
                }
                break;
            default:
                Console.WriteLine("No se puede realizar la operacion");
                break;
        }

    Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
    string confirmacion = Console.ReadLine();
    int.TryParse(confirmacion, out opcion);
} while (opcion == 1);

MiCalculadora.sumar(20);
MiCalculadora.multiplicar(2);
MiCalculadora.multiplicar(3);
MiCalculadora.dividir(2);
double Resultado = MiCalculadora.Resultado;
System.Console.WriteLine(Resultado);