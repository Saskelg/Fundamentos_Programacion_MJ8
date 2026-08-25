using System;

namespace _1.E.Taller_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codigo fuente aca

            /*1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son 
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en 
            pantalla los números de menor a mayor. 
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben 
            ingresar números diferentes.*/

            //variables
            /*
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            //interfaz

            Console.WriteLine("Porfavor inserte el valor de tres numeros");

            Console.WriteLine("Inserte el valor del primer numero:");

            
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el valor del segundo numero:");

            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el valor del tercer numero:");

            numero3 = int.Parse(Console.ReadLine());

            //condicionales
            if (numero1 == numero2 || numero2 == numero3 || numero1 == numero3)
            {
                Console.Write("Porfavor insertar valores distintos, que no sean iguales");
            }
            else
            {
                if (numero1 > numero2 && numero1 > numero3)
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero1);
                        Console.WriteLine(numero2);
                        Console.WriteLine(numero3);
                    }
                    else 
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero1);
                        Console.WriteLine(numero3);
                        Console.WriteLine(numero2);
                    }
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero2);
                        Console.WriteLine(numero1);
                        Console.WriteLine(numero3);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero2);
                        Console.WriteLine(numero3);
                        Console.WriteLine(numero1);
                    }
                }
                else if (numero3 > numero1 && numero3 > numero2)
                {
                    if (numero1 > numero2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero3);
                        Console.WriteLine(numero1);
                        Console.WriteLine(numero2);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(numero3);
                        Console.WriteLine(numero2);
                        Console.WriteLine(numero1);
                    }
                }
            }*/
            // volvere a este despues, tecnicamente se como se resuelve, pero es de una forma muy ineficiente
            /* El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si 
            cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
            a. Permita ingresar por teclado si el personaje está en estado invencible (True). 
            b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
            Ejemplo: 
             int numero; 
             Random rnd = new Random(); 
             numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
             Console.WriteLine(numero);
            c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario 
            no hacer nada. */

            //variables

           /* bool estado_invencivilidad;

            int municion; */

            Random rand = new Random();

            /*municion = rand.Next(1, 11);

            //insertado de datos

            Console.WriteLine("¿El personaje está en estado invencible? (true/false)");

            estado_invencivilidad = bool.Parse(Console.ReadLine());

            if (estado_invencivilidad = true && municion > 0)
            {
                Console.WriteLine("El personaje esta disparando");
            }
            */

            int vidas = rand.Next(1, 6);



            char caracter;

            if (vidas > 0)
            {
                caracter = char.Parse(Console.ReadLine());

                switch (caracter)
                {
                    case 'c': 
                        Console.WriteLine("El personaje esta disparando");
                    break;
                }
            }
            else 
            {
                Console.WriteLine();
            }

        }
    }
}
