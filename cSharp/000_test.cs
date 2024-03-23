using System;
namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            int a = 1;
            string b = "1";
            string c = "1";
            Console.WriteLine(a + b + c);
            Console.WriteLine(a + int.Parse(b) + int.Parse(c));

        }
    }
}