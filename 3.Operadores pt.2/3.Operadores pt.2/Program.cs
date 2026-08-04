using System;

namespace _3.Operadores_pt._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //codigo fuente aca

            //Operadores Numericos

            //Incremento decremento

            int dato1 = 0;
            dato1++; //dato1 = dato1 + 1;
            dato1--; //dato1 = dato1 - 1;
            dato1 += 5; //dato1 = dato1 + 5;
            dato1 *= 4; //dato1 = dato1 * 4;
            dato1 /= 2; //dato1 = dato1 / 2;

            //Operadores logicos

            //conjuncion - AND - Y - &&

            Console.WriteLine("----------------TABLA DE CONJUNCION----------------");
            Console.WriteLine("V && V = "+ (true && true));
            Console.WriteLine("V && F = "+ (true && false));
            Console.WriteLine("F && V = "+ (false && true));
            Console.WriteLine("F && F = "+ (false && false));
            Console.WriteLine("---------------------------------------------------");

            //disyuncion - OR - O - ||

            Console.WriteLine("----------------TABLA DE DISYUNCION----------------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("---------------------------------------------------");

            //negacion - no - !

            bool dato2 = true;
            bool dato3 = !dato2;

            //Operadores de comparacion

            bool dato4 = 5 > 4;
            bool dato5 = 5 <= 4;
            bool dato6 = dato4 == dato2;
            bool dato7 = dato3 != dato2; 
        }
    }
}
