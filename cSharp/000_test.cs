using System;
using System.Security.Cryptography.X509Certificates;
namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            int num = -6;
            int absoluteNum = Math.Abs(num);
            Console.WriteLine(absoluteNum);

            int baseNumber = 2;
            int exp = 5;
            Console.WriteLine(Math.Pow(baseNumber, exp));

            double num3 = 16;
            Console.WriteLine(Math.Sqrt(num3));

            Console.WriteLine(Math.Log(16));

            string sentence = "hola, how ar";
            string[] words = sentence.Split(',');
            Console.WriteLine("sentences has " + words.Length + " " + words[0]);

            string sentence2 = "hello, world";
            string[] text = sentence2.Split(',');
            Console.WriteLine(text.Length + text[0] + text[1]);

            string text2 = "Hello world";
            Console.WriteLine(text2.IndexOf('o'));

            string text3 = "hello world";
            Console.WriteLine(text3.IndexOf('w'));

            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);

            char num5 = '8';
            bool checkerDigit = char.IsDigit(num5); 
            Console.WriteLine(checkerDigit);

            char num6 = '6';
            bool checknum6 = char.IsDigit(num6);

            char num7 = '7';
            bool checkNum7 = char.IsDigit(num7);
            Console.WriteLine(checkNum7);

            char num8 = '8';
            bool checkNum8 = char.IsDigit(num8);
            Console.WriteLine(checkNum8);

            char num9 = '9';
            bool checkNum9 = char.IsDigit(num9);
            Console.WriteLine(checkNum9);

            char num10 = '10';
            bool checkNum10 = char.IsDigit(num10);
            Console.WriteLine(checkNum10);

        }
    }
}
