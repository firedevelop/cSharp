using System;
namespace cSharp
{
    public class VT07_Function_Recursiva
    {
        public static void Print()
        {

            int bNum, pwr;
            int result;

            Console.Write(" Intrdoduce la base : ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Introduce el exponente : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(bNum, pwr);

            Console.Write(" El resultado es {0} \n\n", result);
        }

        public static int CalcuOfPower(int x, int y)
        {

            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
            /* 
                CalcuOfPower(5,1) = 5
                return 5 * 5 = 25
            */
        }
    }
}
