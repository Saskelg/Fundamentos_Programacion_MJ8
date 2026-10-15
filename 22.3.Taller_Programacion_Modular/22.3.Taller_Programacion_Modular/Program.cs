using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._3.Taller_Programacion_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void menu()
        {
            int opcion;
            Console.WriteLine("Seleccione un tipo de unidad de medida:");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Longitud");
            Console.WriteLine("3. Tiempo");
            Console.WriteLine("4. Capacidad");
            Console.WriteLine("5. Salir");
        }

        static void ConvertirMasa()
        {
            Console.WriteLine("Seleccione la unidad de masa a convertir:");
            Console.WriteLine("1. Kilogramos a gramos");
            Console.WriteLine("2. Gramos a kilogramos");
        }
    }
}
