using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Taller_Programacion_Modular
{
    internal class Program
    {
        /*Desarrolla un programa que permita: 
        Ingresar una palabra 
        LLevar la palabra ingresada a un vector de caracteres 
        Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
        usuario. 
        */
        static void Main(string[] args)
        {
            ConvertirAVector(IngresarPalabra());
        }

        static string IngresarPalabra()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            return palabra;
        }
        static char[] ConvertirAVector(string palabra)
        {
            char[] vector = palabra.ToCharArray();
            ContarVocalesYConsonantes(vector);
            return vector;
        }

        static void ContarVocalesYConsonantes(char[] vector)
        {
            int vocales = 0;
            int consonantes = 0;
            foreach (char c in vector)
            {
                if (Char.IsLetter(c) && (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
                {
                    vocales++;
                }
                else
                {
                    consonantes++;
                }
            }
            Console.WriteLine($"Cantidad de vocales: {vocales}");
            Console.WriteLine($"Cantidad de consonantes: {consonantes}");
        }
    }
}
