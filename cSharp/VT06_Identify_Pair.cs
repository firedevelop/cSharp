using System;
namespace cSharp
{
    public class VT06_Identify_Pair
    {
        public static void Print()
        {
            //--------- Declarar el array
            int[] arrayNumeros = new int[10];

            //--------- Informar el array
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.Write("Inserta el número " + i + ": ");
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }

            //--------- Identificar nº pares
            int contador = 0;
            
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i]%2 == 0)
                {
                    contador++;
                    //contador = contador + 1;
                    //contador += 1;
                }
            }

            Console.WriteLine("El número de números pares es: " + contador);
        }

    } 
}