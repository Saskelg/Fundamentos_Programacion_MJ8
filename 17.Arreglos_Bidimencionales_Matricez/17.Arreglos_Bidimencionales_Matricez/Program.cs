using System;

namespace _17.Arreglos_Bidimencionales_Matricez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2, 3]; //Declaración de una matriz de 2x3

            numeros[1,0] = 4; //Asignación de valor a la posición [1,0]

            //numeros[2,0] = 20; //Esto generará un error de índice fuera de rango por fila

            //numeros[0,3] = 30; //Esto generará un error de índice fuera de rango por columna

            numeros[0, 0] = 1;

            numeros[0, 1] = 2;

            numeros[0, 2] = 3;

            numeros[1, 1] = 5;

            numeros[1, 2] = 6;

            //Reuperar dato de una posición específica

            Console.WriteLine("El valor de la posición [1,0] es: " + numeros[1, 0]);

            //Recorrer la matriz con un ciclo for anidado

            for (int i = 0; i < numeros.GetLength(0); i++) //Recorrer filas
            {
                for (int j = 0; j < numeros.GetLength(1); j++) //Recorrer columnas
                {
                    Console.Write($"{numeros[i, j]} |");
                }
                Console.WriteLine(); // Nueva línea después de cada fila
            }

            //otras formas de declarar e inicializar matrices

            string[,] nombres = new string[2, 2] { { "Juan", "Pedro" }, { "Maria", "Luisa" } };

            //Recorrer la matriz de nombres

            for (int i = 0; i < nombres.GetLength(0); i++)
            {
                for (int j = 0; j < nombres.GetLength(1); j++)
                {
                    Console.Write($"{nombres[i, j]} |");
                }
                Console.WriteLine();
            }

            //crear una matriz [10,20], en cada posicion de la matriz poner el numero 100, y mostrar la matriz en la consola.

            int[,] numeros2 = new int[10, 20];
            for (int i = 0; i < numeros2.GetLength(0); i++)
            {
                for (int j = 0; j < numeros2.GetLength(1); j++)
                {
                    numeros2[i, j] = 100;
                }
            }

            //Mostrar la matriz en la consola
            for (int i = 0; i < numeros2.GetLength(0); i++)
            {
                for (int j = 0; j < numeros2.GetLength(1); j++)
                {
                    Console.Write($"{numeros2[i, j]} |");
                }
                Console.WriteLine();
            }

            /* escribe un programa que realize la suma de dos matrices de 2x3
               requisitos del programa:
               solicita al usuario que ingrese los valores de la primera matriz
               solicita al usuario que ingrese los valores de la segunda matriz
               calcula la matriz suma, resultando de sumar cada elemento correspondiente de las dos matrices.
               muestra la matriz de la suma en la consola.*/

            int[,] matriz1 = new int[2, 3];

            int[,] matriz2 = new int[2, 3];

            int[,] matrizSuma = new int[2, 3];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}] de la primera matriz: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}] de la segunda matriz: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("La matriz suma es:");
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    Console.Write($"{matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }

        }
    }
}
