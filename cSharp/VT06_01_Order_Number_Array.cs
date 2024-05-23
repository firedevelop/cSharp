using System;
namespace cSharp
{
    public class VT06_01_Order_Number
    {
        public static void Print()
        {   // Ordenar el array utilizando el algoritmo de burbuja "Bubble Sort"
            int[] array1 = { 5, -9, 16, -7, 2, 6, 20, 4, 32, 19 };

            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = 0; j < array1.Length - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array ordenado:");
            foreach (int num in array1)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
