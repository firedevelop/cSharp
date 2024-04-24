using System;
using System.Data;

namespace cSharp
{
    public class VT08_01_Procedimiento_PrintArray
    {
        public static void Print()
        {
            /*
             Debe tener un subprograma que genere números aleatorios entre 0 y 50 ambos inclusive y los guarde en un array de tamaño 10 CREADO EN EL MAIN. Debe tener un subprograma que imprima el vector resultante.
             */
            Random rnd = new Random();
            int[] array1 = new int[10];
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 51);
                
            }
            printArray(array1);
        }

        public static void printArray(int[] array1)
        {
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
