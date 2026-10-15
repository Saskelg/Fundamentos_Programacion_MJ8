using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._2.Taller_Programacion_Modular
{
    internal class Program
    {

        /*Crear un programa que permita gestionar una lista de tareas: 
        Agregar tareas. 
        Eliminar tareas 
        Mostrar la lista de tareas. */
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            List<string> tareas = new List<string>();
            int opcion = 0;
            do
            {
                Console.WriteLine("----------------------Menu----------------------");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar lista de tareas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("------------------------------------------------");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Clear();
                    agregarTarea(tareas);
                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    eliminarTarea(tareas);
                }
                else if (opcion == 3)
                {
                    Console.Clear();    
                    mostrarTareas(tareas);
                }
                else if (opcion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Saliendo del programa...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
            }
            while (opcion != 4);
        }

        static void agregarTarea(List<string> tareas)
        {
            Console.Write("Ingrese la tarea: ");
            tareas.Add(Console.ReadLine());
            Console.WriteLine("Tarea agregada correctamente, presione cualquier tecla para continuar.");
            Console.ReadKey();
            //limpiar la consola
            Console.Clear();
        }

        static void eliminarTarea(List<string> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
                return;
            }

            Console.WriteLine($"Ingrese el número de la tarea que desea eliminar de 1 a {tareas.Count}");
            int eliminar = int.Parse(Console.ReadLine());
            if (eliminar < 1 || eliminar > tareas.Count)
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            tareas.RemoveAt(eliminar - 1);
            Console.WriteLine("Tarea eliminada correctamente, presione cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        static void mostrarTareas(List<string> tareas)
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
            Console.WriteLine("Presione Cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
