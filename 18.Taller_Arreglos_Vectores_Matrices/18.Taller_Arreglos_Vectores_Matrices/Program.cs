using System;

namespace _18.Taller_Arreglos_Vectores_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            pantalla la suma de los elementos de cada columna.

            int[,] matriz = new int[10, 20];

            // Llenar la matriz con valores aleatorios

            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }

            // Calcular la suma de los elementos de cada columna
            int[] sumaColumnas = new int[matriz.GetLength(1)];

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaColumnas[j] = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    sumaColumnas[j] += matriz[i, j];
                }
            }

            // Mostrar la suma de los elementos de cada columna
            Console.WriteLine("Suma de los elementos de cada columna:");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
            }
            //mostrar la matriz
            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }*/

            /*2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
            matriz con el intercambio de filas*/

            /*int[,] matriz;
            int n, m;

            // Solicitar al usuario el tamaño de la matriz

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            m = int.Parse(Console.ReadLine());
            matriz = new int[n, m];

            // Llenar la matriz con valores aleatorios del 1 al 10

            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 11);
                }
            }

            // Mostrar la matriz original

            Console.WriteLine("\nMatriz original:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            // Intercambiar la primera fila con la última fila de la matriz

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }

            // Mostrar la matriz con el intercambio de filas

            Console.WriteLine("\nMatriz con el intercambio de filas:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }*/

            /*Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            5x5 llena de números aleatorios. 
            El algoritmo debe permitir:
            Usa la función Random para generar los números aleatorios. 
            Crea un arreglo adicional para almacenar la frecuencia de cada número. 
            Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/

            /*int[,] matriz = new int[5, 5];

            // Llenar la matriz con valores aleatorios del 1 al 10

            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }

            //crear un arreglo adicional para almacenar la frecuencia de cada número del 1 al 10

            int[] frecuencia = new int[10];

            // Contar la frecuencia de cada número del 1 al 10 en la matriz

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    frecuencia[matriz[i, j] - 1]++;
                }
            }

            // Mostrar la matriz y el arreglo con la frecuencia de cada número

            Console.WriteLine("\nMatriz:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nFrecuencia de cada número del 1 al 10:");

            for (int k = 0; k < frecuencia.Length; k++)
            {
                Console.WriteLine($"Número {k + 1}: {frecuencia[k]} veces");
            }*/

            /*Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
            posición de una "X".
            El algoritmo debe permitir:
            Usar la función Random para colocar las "X" en la matriz. 
            Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
            Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
            posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. */

            /*char[,] tablero = new char[5, 5];

            // Colocar 3 "X" en posiciones aleatorias del tablero, el resto de las posiciones se llenan con "O"

            //asegurar que no se repitan las posiciones de las "X"

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = 'O';
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int fila, columna;
                do
                {
                    fila = random.Next(0, 5);
                    columna = random.Next(0, 5);
                } while (tablero[fila, columna] == 'X');
                tablero[fila, columna] = 'X';
            }
            // Permitir al usuario intentar adivinar la posición de una "X" en 3 intentos
            bool acierto = false;
            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine($"\nIntento {intento}: Ingrese las coordenadas de la fila y columna (0-4) separadas por un espacio:");
                string[] coordenadas = Console.ReadLine().Split(' ');
                int filaUsuario = int.Parse(coordenadas[0]);
                int columnaUsuario = int.Parse(coordenadas[1]);
                if (tablero[filaUsuario, columnaUsuario] == 'X')
                {
                    acierto = true;
                    Console.WriteLine("¡Felicidades! Has acertado la posición de una 'X'.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lo siento, no has acertado. Intenta nuevamente.");
                }
            }
            if (!acierto)
            {
                Console.WriteLine("\nNo has acertado ninguna posición. La matriz es:");
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        Console.Write($"{tablero[i, j]} |");
                    }
                    Console.WriteLine();
                }
            }*/

            /* Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz 
            de enteros 
            Cargue los datos de la matriz ingresándolos por teclado 
            Muestre la matriz ingresada 
            Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser 
            ahora la columna 1. 
            Mostrar la nueva matriz*/

            /*int[,] matriz;
            int[,] matrizInvertida;

            // Solicitar al usuario el tamaño de la matriz

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            int m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            matrizInvertida = new int[m, n];

            //llenar la matriz con valores aleatorios del 1 al 10
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }

            // Mostrar la matriz original

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            //llenar la matriz invertida con los valores de la matriz original
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrizInvertida[j, i] = matriz[i, j];
                }
            }
            // Mostrar la matriz invertida
            Console.WriteLine("\nMatriz invertida:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrizInvertida[i, j]} |");
                }
                Console.WriteLine();
            }*/

            /*Crear una matriz de n filas por m columnas 
            Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
            Mostrar la matriz generada 
            Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
            número 3, y cuál de los tres números fue repetido más veces*/

            int[,] matriz;

            int n, m;

            int num1 = 0, num2 = 0, num3 = 0;

            // Solicitar al usuario el tamaño de la matriz

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            //llenar la matriz con valores aleatorios del 1 al 3

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 4);
                }
            }

            // Mostrar la matriz generada

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            // Contar cuantas veces fue ingresado el número 1, el número 2, y el número 3

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == 1)
                    {
                        num1++;
                    }
                    else if (matriz[i, j] == 2)
                    {
                        num2++;
                    }
                    else if (matriz[i, j] == 3)
                    {
                        num3++;
                    }
                }
            }

            // Mostrar los resultados
            Console.WriteLine($"\nEl número 1 fue ingresado {num1} veces.");
            Console.WriteLine($"El número 2 fue ingresado {num2} veces.");
            Console.WriteLine($"El número 3 fue ingresado {num3} veces.");

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El número 1 fue repetido más veces.");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("El número 2 fue repetido más veces.");
            }
            else
            {
                Console.WriteLine("El número 3 fue repetido más veces.");
            }
        }
    }
}
