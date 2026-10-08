using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Ejercicios_Modulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mostrar_Menu();
            Realizar_Operaciones(Capturar_Opcion());
        }

        static void Mostrar_Menu()
        {
            Console.WriteLine("-----------------------MENU-----------------------");
            Console.WriteLine("1. Sumar                    2. Restar");
            Console.WriteLine("3. Multiplicar              4. Dividir");
            Console.WriteLine("0. Salir");
            Console.WriteLine("--------------------------------------------------");
        }

        static int Capturar_Opcion()
        {   
            return int.Parse(Console.ReadLine());
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void Realizar_Operaciones( int opcion)
        {
            // This method will call the corresponding operation based on the user's choice
            while (opcion != 0)
            {
                switch (opcion)
                {
                    //the cases also give the result of the operation to the user
                    case 1:
                        float resultadoSuma = Sumar();
                        Console.WriteLine(resultadoSuma);
                        break;
                    case 2:
                        float resultadoResta = Restar();
                        Console.WriteLine(resultadoResta);
                        break;
                    case 3:
                        float resultadoMultiplicacion = Multiplicar();
                        Console.WriteLine(resultadoMultiplicacion);
                        break;
                    case 4:
                        float resultadoDivision = Dividir();
                        Console.WriteLine(resultadoDivision);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
                BorrarPantalla();
                Mostrar_Menu();
            }
        }

        static float Sumar()
        {
            float num1;
            Console.Write("Ingrese un número para sumar: ");
            num1 = float.Parse(Console.ReadLine());
            char respuesta;
            do
            {
              Console.Write("Ingrese otro número para sumar: ");
                float num2 = float.Parse(Console.ReadLine());
                num1 += num2;
                Console.WriteLine("Desea seguir sumando? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return num1;
        }

        static float Restar()
        {
           float numero, resta;
            char respuesta;
            Console.Write("Ingrese un número para restar: ");
            resta = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Ingrese valor a restar: ");
                numero = float.Parse(Console.ReadLine());
                resta -= numero;
                Console.WriteLine("Desea seguir restando? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return resta;
        }

        static float Multiplicar()
        {
            float numero, multiplicacion;
            char respuesta;
            do
            {
                multiplicacion = 1;
                Console.Write("Ingrese un número para multiplicar: ");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea ingresar otro número? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return multiplicacion;
        }

        static float Dividir()
        {
            float num1, num2;
            num2 = 1;
            do
            {
                Console.Write("Ingrese el primer número: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = float.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
            } while (num2 == 0);
            return num1 / num2;
        }
    }
}
