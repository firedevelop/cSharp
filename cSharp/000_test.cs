using System;
using System.Data;

namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            int row = 2, column = 3;
            Random rnd = new Random();
            int sum = 0;
            int rowSum = 0;

            int[,] array1 = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j =0; j < column; j++)
                {
                    array1[i, j] = rnd.Next(1, 5);
                }
            }

            for(int i = 0; i < row; i++)
            {    
                Console.WriteLine("");
                for (int j = 0; j < column; j++)
                {
                    rowSum = array1[i, j];
                    sum += rowSum;
                    Console.Write(" = " + sum);
                    Console.Write(array1[i, j] + " "); 
                }
            }
        }
    }
}
