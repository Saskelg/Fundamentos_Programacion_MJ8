using System;

namespace _5.Condicionales_Anidados_Diagrama_Flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //codigo fuente aca

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Debe ingresar tres valores");

            Console.WriteLine("ingrese el valor del primer numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del tercer numero");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("El numero 1 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }
            else
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }

        }
    }
}

