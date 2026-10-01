using System;

namespace _19.Programacion_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludar("Juan");
            Sumar(5, 10);
            Console.WriteLine($"Tu edad es: {CalcularEdad(1990)}");
            Console.ReadKey();
            BorrarPantalla();
        }
        //procedimiento sin parametros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //procedimiento con parametros
        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
        //Procedimiento con varios parametros

        static void Sumar(int a, int b)
        {
            Console.WriteLine($"La suma de {a} y {b} es: {a + b}");
        }

        //funciones con parametros locales
        static int CalcularEdad(int anioNacimiento)
        {
            int anioActual = 2026;
            int Edad = anioActual - anioNacimiento;
            return Edad;
        }
    }
}
