using System;
namespace cSharp
{
    internal class VT7_Internal_Class
    {
            public static void Print()
            {
                Console.WriteLine("Hola onliners.");
                Console.WriteLine(Suma(4, 5)); Suma1(4, 5);
            }
            public static int Suma(int num1, int num2)
            {
                return num1 + num2;
            }
            public static void Suma1(int num1, int num2) 
            { 
                Console.WriteLine(num1 + num2); 
            }
    }
}