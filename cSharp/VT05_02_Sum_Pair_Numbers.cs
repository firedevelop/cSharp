using System;
namespace cSharp
{
    public class VT06_02_Sum_Pair_Numbers
    {
        public static void Print()
        {
            /* Escribe un programa que declare un vector de números enteros tamaño 10, que pida los valores por teclado y que cuente los números pares que tiene */

            int[] num = new int[10];
            int sum = 0;
            Console.WriteLine("Entry 10 numbers");

            for (int i = 0; i < num.Length; i++)
            {
                int numUser = int.Parse(Console.ReadLine());
                num[i] = numUser;
            }
            foreach (int j in num)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("array: " + j);
                    sum += j;

                }

            }
            Console.WriteLine("sum: " + sum);
            /*//--------- Declarar el array
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

            Console.WriteLine("El número de números pares es: " + contador); */
        }

    }
}