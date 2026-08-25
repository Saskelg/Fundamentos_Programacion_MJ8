using System;

namespace _7.Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //codigo fuente aca

            //variables

            /*int contador = 1;
            int acumulador = 1;
            //ciclo
            while (contador < 5) 
            {
                contador++;
                acumulador = acumulador + contador;
            }
            
            Console.WriteLine("La suma de los primeros 5 factorials enteros positivos es:" + acumulador);*/

            byte factorial = 0;

            int contador = 1;

            int acumulador = 1;

            Console.WriteLine("Que valor quiere sacarle factorial?");

            factorial = byte.Parse(Console.ReadLine());

            while (contador < factorial) 
            {
                contador++;
                acumulador = acumulador * contador;
            }

            Console.WriteLine("El factorial de " + factorial + " es: " + acumulador);

        }
    }
}
