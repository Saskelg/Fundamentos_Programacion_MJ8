using System;


namespace _2.P.Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una pequeña bodega necesita un programa para registrar las entradas de mercancía que van llegando a lo largo del día. 
            Utiliza una estructura repetitiva adecuada (while o do-while) que permita registrar lotes de forma indefinida hasta que el usuario decida terminar. El programa debe cumplir con lo siguiente:
            En cada iteración, solicitar el código del producto (un número entero) y la cantidad de unidades ingresadas.
            Condición de salida: El ciclo debe repetirse mientras el código del producto sea diferente de -1 (el código -1 indica que ya no hay más lotes por registrar).
            Validación con Condicional: Si la cantidad de unidades ingresada es menor o igual a 0, el programa debe mostrar un mensaje de advertencia "Cantidad inválida, no se sumará al inventario" y omitir ese registro sin romper el ciclo.
            Estadísticas de Cierre: Al finalizar el ingreso de datos (cuando el usuario digite -1), el programa debe mostrar en pantalla:
            El total acumulado de unidades ingresadas en la bodega durante todo el día.
            Cuántos lotes válidos se registraron en total.*/

            int total_Unidades = 0;

            int cantidad_unidades = 0;

            int Cantidad_Productos = 0;

            int codigo_producto = 0;

            while (codigo_producto != -1) 
            {
                Console.WriteLine("Ingrese el código del producto (o -1 para terminar): ");
                codigo_producto = int.Parse(Console.ReadLine());

                if (codigo_producto != -1)
                {
                    Console.WriteLine("Ingrese la cantidad de unidades ingresadas: ");
                    cantidad_unidades = int.Parse(Console.ReadLine());

                    if (cantidad_unidades > 0)
                    {
                        total_Unidades += cantidad_unidades;
                        Cantidad_Productos++;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida, no se sumará al inventario");
                    }
                }
                else 
                {
                    break;
                }
            }
            Console.WriteLine("Total de unidades ingresadas: " + total_Unidades);
            Console.WriteLine("Cantidad de lotes válidos registrados: " + Cantidad_Productos);

        }
    }
}
