using System;

namespace cSharp
{
    public class c020_static
    {
        public static void Print()
        {
            int num1 = 5;
            int num2 = 3;

            Console.WriteLine("El resultado de la suma es {0}", (num1 + num2));

            Console.WriteLine("El resultado de la suma es {0}", suma(num1, num2));
        }

        static int suma(int a, int b)
        {
            return a + b;
        }
    }
}
