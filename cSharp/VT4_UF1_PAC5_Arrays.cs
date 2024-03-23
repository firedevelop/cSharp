using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.InteropServices;
namespace cSharp
{
    public class VT4_UF1_PAC5_Arrays
    {
        enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        public static void Print()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = [4, 5, 6];
            int[] array3 = { 7, 8, 9 };
            string[] array4 = { "one", "two" };
            string[] array5 = ["two", "three"];

            foreach (int i in array1) { Console.WriteLine(i); }
            foreach (int i in array2) { Console.WriteLine(i); }
            foreach (int i in array3) { Console.WriteLine(i); }
            foreach (string i in array4) { Console.WriteLine(i); }
            foreach (string i in array5) { Console.WriteLine(i); }

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                { break; }
                Console.Write(i); // 1234
            }
            foreach (Day day in Enum.GetValues(typeof(Day)))
            {Console.WriteLine(day); } //Sat Sun Mon Tue Wed Thu Fri


            int[] numeros = new int[10];
            foreach (int numero in numeros)
            { Console.WriteLine(numero); } // Print ten zeros

        }
    }     
}