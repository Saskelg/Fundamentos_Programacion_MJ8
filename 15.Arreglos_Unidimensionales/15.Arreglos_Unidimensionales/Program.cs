using System;


namespace _15.Arreglos_Unidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales o Vectores

            /* int[] numeros = new int[5]; //Declaración de un arreglo de enteros con 5 elementos

            numeros[0] = 15; //Asignación de valores a cada elemento del arreglo

            numeros[1] = 10; //Asignación de valores a cada elemento del arreglo

            numeros[2] = 20; //Asignación de valores a cada elemento del arreglo

            numeros[3] = 25; //Asignación de valores a cada elemento del arreglo

            numeros[4] = 30; //Asignación de valores a cada elemento del arreglo

            //numeros[5] = 100; Esto generará un error de índice fuera de rango, ya que el arreglo tiene solo 5 elementos (índices del 0 al 4)

            Console.WriteLine($"El dato en la posición 4 con indice 3 es: {numeros[3]}");

            //Las matrizes pueden ser de cualquier tipo de dato, no solo enteros. Por ejemplo, podemos tener un arreglo de flot, de string, de bool, etc. A continuación se muestra un ejemplo de un arreglo de strings:

            float[] numerosFlotantes = new float[5]; //Declaración de un arreglo de flotantes con 5 elementos
            numerosFlotantes[0] = 15.5f;
            numerosFlotantes[1] = 10.0f;
            numerosFlotantes[2] = 20.5f;
            numerosFlotantes[3] = 25.0f;
            numerosFlotantes[4] = 30.5f;

            //otras formas de declarar e inicializar arreglos unidimensionales

            char[] simbolos = new char[] { 'a', 'b', 'c', 'd', 'e' }; //Declaración e inicialización de un arreglo de caracteres con 5 elementos
            bool[] valoresBooleanos = new bool[] { true, false, true, false, true }; //Declaración e inicialización de un arreglo de booleanos con 5 elementos

            //Recorrer un arreglo unidimensional con un ciclo for

            string[] nombres = new string[7]; //Declaración de un arreglo de strings con 7 elementos
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona {i + 1}: ");
                nombres[i] = Console.ReadLine(); //Asignación de valores a cada elemento del arreglo
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($" {nombres[i]} |");
            } */

            /* Crear un arreglo llamado "enteros" de 100 elementos, asignar el valor 10 a cada una de las posiciones del
               arreglo. Leer el contenido de cada elemnto y mostrarlo en pantalla */
            int[] enteros = new int[100];
            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
            }
            for (int i = 0; i < enteros.Length; i++)
            {
                Console.Write($" {enteros[i]} |");
            }

        }
    }
}
