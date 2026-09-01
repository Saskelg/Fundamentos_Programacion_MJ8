using System;

namespace _9.Ciclos_While_eEercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            byte valor_a_introducir = 0;

            int numero = 0;

            byte contador_principal = 0; 

            byte contador_mayor_cero = 0;

            byte contador_menor_cero = 0;

            byte contador_cero = 0;

            //interfaz y entrada

            Console.WriteLine("Ingrese la cantidad de numeros que va a introducir");

            valor_a_introducir = byte.Parse(Console.ReadLine());

            //ciclo

            while (contador_principal != valor_a_introducir) 
            {
                Console.WriteLine("Ingrese al valor del numero:");

                numero = int.Parse(Console.ReadLine());

                contador_principal++;

                if (numero == 0)
                {
                    contador_cero++;
                }
                if (numero > 0)
                {
                    contador_mayor_cero++;
                }
                if (numero < 0)
                {
                    contador_menor_cero++;
                }
            }

            //salida

            Console.WriteLine("Cantidad de numeros ingresador mayores que cero: " + contador_mayor_cero);

            Console.WriteLine("Cantidad de numeros ingresador menores que cero: " + contador_menor_cero);

            Console.WriteLine("Cantidad de numeros ingresador iguales a cero: " + contador_cero);
        }
    }
}