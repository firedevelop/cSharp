using System;
/*Realice un programa modular donde se calcule la suma de los dígitos de un número que el usuario introduzca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado szca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado sería: 3 + 6 + 9 = 18 */
namespace cSharp
{
    public class VT6_Substring
    {
        public static int Calcular(int a) { 
        string cad = Convert.ToString(a);   

        int sum = 0;  for (int i = 0; i<cad.Length; i++)
             sum += Convert.ToInt32(cad.Substring(i,1)); 
            return sum;
        }
        public static void Print()
        {

        int numero;
            Console.Write("Introduzca el número: ");      
            numero = Convert.ToInt32( Console.ReadLine() );      
            Console.WriteLine(Calcular(numero));
        }

    }
}