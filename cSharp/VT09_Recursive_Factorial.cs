using System;
namespace cSharp
{
    public class VT09_Recursive_Factorial
    {
        /*
        Calcular el factorial de un número usando un método no recursivo y recursivo:
        Fórmula para calcular el factorial de un número:
        n! = n* (n−1)!
        5! = 5 * 4 * 3 * 2 * 1 = 120
        */
        public static void Print()
        {
            int num = 5;
            int total = 1;
            int factor;

            for (int i = num; i > 0; i--)
            {
                factor = i;
                total *= factor;
            }
            Console.WriteLine("Factorial NO Recursive: " + total);

            total = FactorialRecursive(num);
            Console.WriteLine("Factorial Recursive: " + total);


        }
        public static int FactorialRecursive(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * FactorialRecursive(num - 1);
            }
        }


    }
}
