using System;
/*Realice un programa modular donde se calcule la suma de los dígitos de un número que el usuario introduzca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado szca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado sería: 3 + 6 + 9 = 18 */
namespace cSharp
{
    public class VT6_Array
    {
        public static int Sum(int[] arr1)
        {
            int tot = 0; 
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }
        public static void Print()
        {
            int[] arr1 = new int[5];
            Console.Write("introduce cinco elementos del array :\n");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("elemento - {0} : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("El resultado es {0}", Sum(arr1));
        }
    }
}