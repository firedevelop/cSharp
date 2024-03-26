﻿using System;

namespace PAC_Desarrollo_Entrega_2S2324
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Declaracion de variables
            string frase = "";
            string resultado = "";


            //------------------------------------------------------------------------------------------ Ejecución libre del programa

            //-------------------------- Se valida que la frase introducida sea correcta
            do
            {
                Console.Write("Inserta una frase para que la analice: ");
                frase = Console.ReadLine();

            } while (FraseValida(frase) == false);

            //-------------------------- Se obtiene la cuenta de caracteres mayúsculos, minúsculos, numéricos y otros
            resultado = ContarCaracteres(frase);
            Console.WriteLine(resultado);

            //-------------------------- Se obtiene la frase invertida
            resultado = InvertirFrase(frase);
            Console.WriteLine(resultado);

            //-------------------------- Se obtiene la primera posición donde aparece el número que más veces está en el array
            Console.WriteLine(CaracterMasRepetido(frase));

            //--- Fin de la ejecución del programa
        }

        public static bool FraseValida(string frase)
        {
            /*
			*
			*	ESPACIO DONDE EL ALUMNO DEBE IMPLEMENTAR LA SOLUCIÓN
			*
			*/
        }

        public static string ContarCaracteres(string frase)
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            /*
			*
			*	ESPACIO DONDE EL ALUMNO DEBE IMPLEMENTAR LA SOLUCIÓN
			*
			*/

            return "La frase contiene " + mayusculas + " letras mayúsculas, " + minusculas + " letras minúsculas y " + numeros + " números.";
        }

        public static string InvertirFrase(string frase)
        {
            /*
			*
			*	ESPACIO DONDE EL ALUMNO DEBE IMPLEMENTAR LA SOLUCIÓN
			*
			*/
        }

        public static string CaracterMasRepetido(string frase)
        {
            char[] arrLetras = new char[frase.Length];
            int[] arrContadorLetras = new int[frase.Length];
            int posicion;
            int contador;

            /*
			*
			*	ESPACIO DONDE EL ALUMNO DEBE IMPLEMENTAR LA SOLUCIÓN
			*
			*/

            if (contador > 1)
            {
                return "El valor '" + arrLetras[posicion - 1] + "' se repite " + arrContadorLetras[posicion - 1] + " veces y la primera vez que aparece en la frase es en la posición " + posicion + ".";
            }
            else
            {
                return "Todos los caracteres de la frase aparecen por igual.";
            }
        }
    }
}