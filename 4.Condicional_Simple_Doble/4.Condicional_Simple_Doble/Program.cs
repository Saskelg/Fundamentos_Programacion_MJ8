using System;


namespace _4.Condicional_Simple_Doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //codigo fuente

            //condicional simple

            //variable edad
            /* byte edad = 0;

            //codigo que ingresa la edad del usuario

            Console.WriteLine("ingrese su edad:");

            edad = Convert.ToByte(Console.ReadLine());

            //condicional

            if (edad >= 18) {
                //si la condicion es verdadera

                Console.WriteLine("Bienvenido al internet");
            }*/
            //fin del condicional

            //variables

            /*int sueldo = 0;

            string nombre;

            //codigo para ingresar nombre y sueldo

            Console.WriteLine("Ingrese su nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo en pesos:");

            sueldo = Convert.ToInt16(Console.ReadLine());

            //condicional

            if (sueldo >= 3000) {

                //si el sueldo es mayo a 3000 pesos

                Console.WriteLine(nombre + ", debido a que su sueldo es de " + sueldo + " pesos, tiene que abonar impuestos");
            }*/
            //fin condicional


            //condicional doble

            //variable

            byte edad = 0;

            //codigo que ingresa la edad del usuario

            Console.WriteLine("ingrese su edad:");

            edad = Convert.ToByte(Console.ReadLine());

            //condicional

            if (edad >= 18)
            {
                //si la condicion es verdadera

                Console.WriteLine("Bienvenido al internet");
            }
            else { 
                //si la condicion es falsa

                Console.WriteLine("Tu edad no es apta para este contenido");
            
            }
            //fin condicional
        }
    }
}
