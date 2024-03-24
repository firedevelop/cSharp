using System;
namespace cSharp
{
    public class c010_for_odd_pair
    {
        public static void Print()
        {
            Console.WriteLine("FOR");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} pair", i);
                } else   
                {
                    Console.WriteLine("{0} odd", i);
                }
            }

            Console.WriteLine("\n WHILE");
            int j= 0;
            while (j < 10)
            {
                if(j%2 == 0)
                {
                    Console.WriteLine("{0} pair", j);
                }
                else
                {
                    Console.WriteLine("{0} odd", j);
                }
                j++;
            }
            Console.WriteLine("\n DO WHILE");
            int k= 0;
            do { 
                if(k % 2 == 0)
                {
                    Console.WriteLine("{0} pair", k);
                }
                else
                {
                    Console.WriteLine("{0} odd", k);
                }
                k++;
            } 
            while (k < 10);
        }
    }
}
