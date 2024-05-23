using System;
namespace cSharp
{
    public class VT09_Recursive_Functions
    {
        public static void Print()
        {
            CuentaAtras(3);
        }
        public static void CuentaAtras(int numero)
        {
            Console.Write(numero + " - ");

            if (numero > 0)
            {
                CuentaAtras(numero - 1);
            }
        }
    }

}