using System;

namespace _2.Constantes_Tipos_Datos_Aperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //codigo fuente aca
            //constantes

            const string iva = "19%";
            string nombre = "Samuel";

            //cambio de valor en variable, no se puede hacer con las constantes

            nombre = "Pepito Perez";

            //tipos de datos

            //byte: numerico desde 0 a 255

            byte dato1 = 1;

            //int o integer: numerico con mayor limite incluyendo negativos

            int dato2 = 2763;

            //long: numerico que tambien puede contener caracteres

            long dato3 = 1L;

            //float: numerico decimal, se debe incluir f al final o el sistema lo confundira con un double

            float dato4 = 1.0f;

            //double: numerico decimal de dos cifras, se debe poner d al final

            double dato5 = 1.45d;

            //decimal: numerico decimal de cifras mas largas para mas precision, se debe poner m al final

            decimal dato6 = 2.763m;

            //char: variable de UN solo caracter (estrictamente 1) y se deben poner entre comillas singulares ''

            char dato7 = 'A';

            //string: variable de cadena de caracteres, se puede poner cualquier cosa, se deben poner entre comillas dobles

            string dato8 = "OIADIBDAOIDBADOAWDNONO98219Y1283U12B1'1+´´+'| 022'1 ";

            //boolean: dato que solo se puede poner "true" o "false"

            Boolean dato9 = true;

            //object: variable que crea objetos a travez de una clase, todas las clases que se hagan heredan de object

            object dato10 = new object();

            //OPERADORES

            //numericos

            //cambio de signo

            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1} ",dato11,dato12);

            //aritmeticos

            int dato13 =  dato11 - dato12;
            Console.WriteLine("El resultado de la resta es: {0}",dato13);
            int dato14 = 5 * dato13;
            Console.WriteLine("El resultado de la multiplicacion es: {0}",dato14);
            float dato15 = 6f / 7f;
            Console.WriteLine("El resultado de la division es: {0}", dato15);
        }
    }
}
