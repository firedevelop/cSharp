using System;
using System.ComponentModel;
namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            string text = "Hello World!";
            string textGet = text.Substring(1, 4);
            Console.WriteLine(textGet); // ello


        }

    }
}
