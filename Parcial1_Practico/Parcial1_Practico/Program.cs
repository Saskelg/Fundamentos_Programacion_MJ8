using System;
using System.Diagnostics.Eventing.Reader;

namespace Parcial1_Practico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un conjunto de personas debe ser clasificado en uno de cuatro grupos: A, B, C o D, de acuerdo con diferentes características de la persona.
            La clasificación se realizará teniendo en cuenta el sexo, la edad, el último dígito del documento de identidad y, únicamente en un caso específico, el dominio del idioma inglés.
            Reglas de clasificación
            Grupo A
            Una persona pertenece al grupo A si cumple alguna de las siguientes condiciones:
            Es mujer, tiene entre 16 y 20 años, inclusive, y el último dígito de su documento de identidad es 0, 4 u 8.
            Es hombre, tiene entre 18 y 22 años, inclusive, y el último dígito de su documento de identidad es 1, 5 o 9.
            Grupo B
            Una persona pertenece al grupo B si cumple alguna de las siguientes condiciones:
            Es mujer, tiene entre 21 y 25 años, inclusive, y el último dígito de su documento de identidad es 3 o 7.
            Es hombre, tiene entre 23 y 26 años, inclusive, y el último dígito de su documento de identidad es 2 o 6.
            Grupo C
            Una persona pertenece al grupo C si:
            Tiene exactamente 15 años, y
            Domina el idioma inglés.
            Importante: el programa solo debe solicitar información sobre el dominio del idioma inglés cuando la persona tenga exactamente 15 años. Para las personas de cualquier otra edad, esta información no debe ser solicitada.
            Grupo D
            Una persona pertenece al grupo D cuando no cumple ninguna de las condiciones establecidas para los grupos A, B o C.
            Los grupos son excluyentes, por lo que cada persona debe ser clasificada en un único grupo.
            Objetivo
            Desarrolle un programa en C# que:
            Solicite el sexo de la persona (masculino o femenino).
            Solicite la edad, como un número entero positivo.
            Solicite el último dígito del documento de identidad, que debe ser un número entre 0 y 9.
            Si la persona tiene 15 años, solicite además si domina el idioma inglés (sí o no).
            Analice la información ingresada y determine el grupo al que pertenece la persona.
            Muestre en pantalla el grupo correspondiente: A, B, C o D.
            Nota: El programa debe utilizar adecuadamente estructuras condicionales para tomar las decisiones necesarias y debe evitar solicitar información que no sea necesaria para determinar la clasificación.*/

            //variables

            char sexo;

            byte edad;

            byte ultimo_digito_documento;

            string dominio_en_ingles;

            //interfaz de usuario

            Console.WriteLine("Cual es su genero (m o f)?");

            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Cual es su edad? (solo el numero)");

            edad = byte.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el ultimo digito en su documento de identidad?");

            ultimo_digito_documento = byte.Parse(Console.ReadLine());

            if (edad == 15)
            {

                Console.WriteLine("usted domina el idioma ingles? si/no");

                dominio_en_ingles = Console.ReadLine();

                if (dominio_en_ingles == "si")
                {
                    Console.WriteLine("Usted pertenece al grupo C");
                }
            }
            else
            {

                if ((sexo == 'f' && edad <= 20 && edad >= 16 && ultimo_digito_documento == 0 || ultimo_digito_documento == 4 || ultimo_digito_documento == 8) || (sexo == 'm' && edad <= 22 && edad >= 18 && ultimo_digito_documento == 1 || ultimo_digito_documento == 5 || ultimo_digito_documento == 9))
                {
                    Console.WriteLine("Usted pertenece al grupo A");
                }
                else 
                {
                    if ((sexo == 'f' && edad <= 25 && edad >= 21 && ultimo_digito_documento == 7 || ultimo_digito_documento == 3) || (sexo == 'm' && edad <= 26 && edad >= 23 && ultimo_digito_documento == 6 || ultimo_digito_documento == 2))
                    {
                        Console.WriteLine("Usted pertenece al grupo B");
                    }
                    else {  Console.WriteLine("Usted pertenece al grupo D"); }
                }
            }
        }
    }
}
