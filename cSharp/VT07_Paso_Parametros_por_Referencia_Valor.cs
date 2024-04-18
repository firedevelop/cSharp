using System;
namespace cSharp
{
    internal class VT7_Paso_Parametros_por_Referencia_Valor
    {
        public static void Print()
        {
            int num1 = 2;
            int num2 = 3;
            sum(ref num1, num2);
            Console.WriteLine(num1 + " " + num2);
        }

        public static void sum(ref int num1, int num2)
        {
            num1++;
            --num2;
        }
    }
}