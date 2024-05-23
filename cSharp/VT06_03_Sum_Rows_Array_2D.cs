using System;
using System.Data;

namespace cSharp
{
    public class VT06_03_Sum_Rows_Array_2D
    {
        public static void Print()
        {
            // 2 4 3  sum=8
            // 1 2 4  sum=7
            int row = 2, column = 3;
            Random rnd = new Random();
            int sum = 0;
           

            int[,] array1 = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j =0; j < column; j++)
                {
                    array1[i, j] = rnd.Next(1, 10);
                }
            }

            for(int i = 0; i < row; i++)
            {
                
                
                for (int j = 0; j < column; j++)
                {
                   
                    Console.Write(array1[i, j] + " ");
                    sum += array1[i, j];
                }
                Console.WriteLine(" sum=" + sum);
                sum = 0;
            }
        }
    }
}
