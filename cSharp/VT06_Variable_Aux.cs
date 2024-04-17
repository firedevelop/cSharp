using System;
/*Realice un programa modular donde se calcule la suma de los dígitos de un número que el usuario introduzca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado szca por pantalla.Por ejemplo, si el usuario introduce el número 369, el resultado sería: 3 + 6 + 9 = 18 */
namespace cSharp
{
    public class VT6_Variable_Aux
    {
        public static void intercambio(ref int numero1, ref int numero2)
        {
            int aux;
            aux = numero1;
            numero1 = numero2;
            numero2 = aux;
        }
            public static void Print()
        {
            int numero1, numero2;
            Console.Write("Introduzca el primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el Segundo número ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            intercambio( ref numero1, ref numero2 ); 
            Console.WriteLine("{0}\n{1}", numero1,numero2);
        }

    }
}