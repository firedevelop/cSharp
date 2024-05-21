namespace cSharp
{
    public class VT10_06_Examen
    {
        public static void Print()
        {
            int num;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.WriteLine("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num < 0);
            factorial(num);
            Console.ReadKey();
        }

        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}

/* output:
Calculo del Factorial de un número entero positivo

Por favor Digite un número entero positivo:
5

El Factorial de 5 es: 120
*/

