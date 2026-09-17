using System;


namespace _16.Taller_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que permita:
            a. Crear dos vectores del mismo tamaño. 
            b. Llenarlos con números. 
            c. Comparar posición por posición. 
            d. Indicar cuántos elementos son iguales

            int tamano;

            int iguales = 0;

            Console.WriteLine("Ingrese el tamaño de los vectores: ");
            tamano = int.Parse(Console.ReadLine());

            int[] vector1 = new int[tamano];
            int[] vector2 = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i + 1} del vector 1: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i + 1} del vector 2: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamano; i++)
            {
                for (int j = 0; j < tamano; j++)
                {
                    if (vector1[i] == vector2[j])
                    {
                        iguales++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de elementos iguales es: {iguales}");
            
            Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 
            0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el 
            número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el 
            vector resaltando el número en un color diferente. Si no se encuentra el número, se debe 
            devolver y mostrar -1.

            int numeroBuscado = 0;

            int[] vector = new int[20];
            
            Random random = new Random();
            
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(0, 51);
            }

            Console.WriteLine("Ingrese un número para buscar en el vector: ");
            numeroBuscado = int.Parse(Console.ReadLine());

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numeroBuscado)
                {
                    Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {i} del vector.");
                    for (int j = 0; j < vector.Length; j++)
                    {
                        if (vector[j] == numeroBuscado)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(vector[j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(vector[j] + " ");
                        }
                    }
                }
            }
            Console.WriteLine("-1");
            Escribir un algoritmo que permita: 
            a. Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el 
            usuario. 
            b. LLenar el primer vector con números aleatorios entre 0 y su rango+1 
            c. LLenar el segundo vector con números aleatorios entre rango y rango*2
            d. Combinar los dos vectores en uno solo. 
            e. Mostrar en pantalla los tres vectores

            int[] vector1, vector2, vectorCombinado;

            int rango1, rango2;

            Console.WriteLine("Ingrese el rango para el primer vector: ");
            rango1 = int.Parse(Console.ReadLine());

            vector1 = new int[rango1];

            Console.WriteLine("Ingrese el rango para el segundo vector: ");
            rango2 = int.Parse(Console.ReadLine());

            vector2 = new int[rango2];

            vectorCombinado = new int[rango1 + rango2];
            
            Random random1 = new Random();
            Random random2 = new Random();

            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = random1.Next(0, rango1 + 1);
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                vector2[i] = random2.Next(rango1, rango2 * 2 + 1);
            }

            for (int i = 0; i < vector1.Length; i++)
            {
                vectorCombinado[i] = vector1[i];
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                vectorCombinado[i + vector1.Length] = vector2[i];
            }

            Console.WriteLine("Vector 1: ");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write(vector1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vector 2: ");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write(vector2[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vector Combinado: ");
            for (int i = 0; i < vectorCombinado.Length; i++)
            {
                Console.Write(vectorCombinado[i] + " ");
            }
            Console.WriteLine();
            
            Escribir un algoritmo que permita:
            a. Crear un vector de nombres. 
            b. Solicitar una letra al usuario. 
            c. Contar cuántos nombres empiezan con esa letra.

            string[] nombres = { "Ana", "Pedro", "Juan", "Maria", "Luis", "Carlos", "Lucia", "Jorge", "Sofia", "Diego" };
            Console.WriteLine("Ingrese una letra: ");
            char letra = char.Parse(Console.ReadLine());
            int contador = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                }
            }

            Console.WriteLine("Cantidad de nombres que empiezan con la letra {0}: {1}", letra, contador);
            Escribir un algoritmo que permita:
            a. Crear un vector de nombres. 
            b. Identificar cuáles se repiten. 
            c. Mostrar cuántas veces aparece cada uno

            string[] nombresRepetidos = { "Ana", "Pedro", "Juan", "Maria", "Luis", "Carlos", "Lucia", "Jorge", "Sofia", "Diego", "Ana", "Pedro", "Juan" };

            for (int i = 0; i < nombresRepetidos.Length; i++)
            {
                int contadorRepetidos = 1;
                for (int j = i + 1; j < nombresRepetidos.Length; j++)
                {
                    if (nombresRepetidos[i] == nombresRepetidos[j])
                    {
                        contadorRepetidos++;
                    }
                }
                if (contadorRepetidos > 1)
                {
                    Console.WriteLine("El nombre {0} se repite {1} veces.", nombresRepetidos[i], contadorRepetidos);*
                }
            }   
            Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
            orden de los elementos del vector. Se deben mostrar lo dos vectores. */

            /*int tamanoVector;

            Console.WriteLine("Ingrese el tamaño del vector: ");

            tamanoVector = int.Parse(Console.ReadLine());

            char[] vectorCaracteres = new char[tamanoVector];

            for (int i = 0; i < tamanoVector; i++)
            {
                Console.WriteLine($"Ingrese el caracter {i + 1}: ");
                vectorCaracteres[i] = char.Parse(Console.ReadLine());
            }

            char[] vectorInvertido = new char[tamanoVector];

            for (int i = 0; i < tamanoVector; i++)
            {
                vectorInvertido[i] = vectorCaracteres[tamanoVector - 1 - i];
            }

            Console.WriteLine("Vector original: ");
            for (int i = 0; i < tamanoVector; i++)
            {
                Console.Write(vectorCaracteres[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vector invertido: ");
            for (int i = 0; i < tamanoVector; i++)
            {
                Console.Write(vectorInvertido[i] + " ");
            }
            Console.WriteLine();
            
            Escribir un algoritmo que permita: 
            a. Crear un vector con rango impar, exceptuando el 1.
            b. Pedirle al usuario un número entero y almacenarlo en la mitad del vector. 
            c. Llenar la primera mitad del vector, con los números menores al número almacenado 
            en la posición de la mitad. 
            d. Llenar la parte inicial del vector, con los números menores al número almacenado 
            en la posición de la mitad. 
            e. Llenar la parte final del vector, con los números mayores al número almacenado en 
            la posición de la mitad. 
            f. Mostrar el vector en pantalla.

            int[] vector = new int[7];

            Console.WriteLine("Ingrese un número entero: ");

            int numero = int.Parse(Console.ReadLine());

            vector[3] = numero;

            for (int i = 0; i < 3; i++)
            {
                vector[i] = numero - (3 - i);
            }

            for (int i = 4; i < 7; i++)
            {
                vector[i] = numero + (i - 3);
            }

            Console.WriteLine("Vector resultante: ");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
            
            Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            encuentre y muestre el valor máximo y mínimo de los números ingresados. */

            int[] vector = new int[15];
            
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elementos del vector: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();

            int maximo = vector[0];
            int minimo = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
                if (vector[i] < minimo)
                {
                    minimo = vector[i];
                }
            }

            Console.WriteLine($"El valor máximo es: {maximo}");
            Console.WriteLine($"El valor mínimo es: {minimo}");
        }
    }
}
