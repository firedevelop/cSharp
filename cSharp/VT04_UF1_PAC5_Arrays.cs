using System.Numerics;
namespace cSharp
{
    public class VT4_UF1_PAC5_Arrays
    {
        enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        enum Num { one, two = 100, three }
        public static void Print()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array = new int[5];
            int[] array2 = { 7, 8, 9 };
            string[] array3 = {"one", "two"};

            foreach (int i in array1) { Console.WriteLine(i); }
            foreach (int i in array2) { Console.WriteLine(i); }
            foreach (string i in array3) { Console.WriteLine(i); }

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                { break; }
                Console.Write(i); // 1234
            }
            foreach (Day day in Enum.GetValues(typeof(Day)))
            { Console.WriteLine(day); } // Sat Sun Mon Tue Wed Thu Fri

            int num1 = (int)Num.one;
            int num2 = (int)Num.two;
            Console.WriteLine(num1 + " " + num2);   // 0 2

            int[] numeros = new int[10];
            foreach (int numero in numeros)
            { Console.WriteLine(numero); } // Print ten zeros

        }
    }
}