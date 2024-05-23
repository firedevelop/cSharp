using System;
using System.IO;
namespace cSharp
{
    public class VT10_02_Examen
    {
        public static void Print()
        {
            {

                string[,] numeros = new string[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        numeros[i, j] = ((i * 10) + (j + 1)).ToString();
                        if (numeros[i, j] == "1" ||
                        (int.Parse(numeros[i, j]) % 2) == 0 ||
                        (int.Parse(numeros[i, j]) % 3) == 0 ||
                        (int.Parse(numeros[i, j]) % 5) == 0 ||
                        (int.Parse(numeros[i, j]) % 7) == 0 ||
                        (int.Parse(numeros[i, j]) % 11) == 0 &&
                        numeros[i, j] != "2" &&
                        numeros[i, j] != "3" &&
                        numeros[i, j] != "5" &&
                        numeros[i, j] != "7" &&
                        numeros[i, j] != "11")
                        {
                            numeros[i, j] = "X";
                        }
                        Console.WriteLine(" {0} ", numeros[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }


    }
}
