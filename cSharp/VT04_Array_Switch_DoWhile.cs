using System;
namespace cSharp
{
    public class VT04_Array_Switch_DoWhile
    {
        public static void Print()
        {
            double num1, num2;
            int operation;
            string[] options = { "[0] exit\n", "[1] sum\n", "[2] substract\n", "[3] multi\n", "[4] division\n" };
            do
            {
                Console.WriteLine(options.Length);
                Console.WriteLine("Insert operation\n");
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }

                operation = int.Parse(Console.ReadLine());

                if (operation != 0 && operation < options.Length)
                {
                    Console.WriteLine("Insert num1");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insert num2");
                    num2 = double.Parse(Console.ReadLine());
                    double result = CalcOperation(num1, num2, operation);
                    Console.WriteLine("Result: " + Math.Round(result, 2));
                }
                else { Console.WriteLine("Invalid option"); break; }




            }
            while (operation != 0);
        }


        public static double CalcOperation(double num1, double num2, int operation)
        {
            double result = 0;
            switch (operation)
            {
                case 0:
                    operation = 0;
                    Console.WriteLine("Exit");
                    break;
                case 1:
                    operation = 1;
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("No valid input");
                    break;

            }
            return result;
        }



    }
}
