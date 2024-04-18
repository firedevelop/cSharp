using System;
namespace cSharp
{
    internal class VT08_in_out_params_PasoPorReferencia
    {

        public static void Print()
        {
            int minVal = 10;
            int maxVal; 

            AnalyzeNumbers(in minVal, out maxVal, 20, 35, 8); 

            Console.WriteLine("Minimum value: " + minVal); 
            Console.WriteLine("Maximum value: " + maxVal); 
        }
        public static void AnalyzeNumbers(in int minValue, out int maxValue, params int[] numbers)
        {
            maxValue = minValue; 

            foreach (int number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
        }

    }
}