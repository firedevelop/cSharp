using System;
namespace cSharp
{
    public class VT08_Random_Array
    {
        public static void Print()
        {

            int[] matriz = new int[10];


            informar_array(matriz);


            visualizar_array(matriz);
        }

        public static void informar_array(int[] matriz)
        {
            Random aleatorio = new Random();

            for(int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = aleatorio.Next(0, 51);
            }
        }

        public static void visualizar_array(int[] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
        }
    }
}