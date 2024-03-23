namespace cSharp
{
    public class c020_static
    {
        public static void Print()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("El resultado de la suma es {0}", (num1 + num2));

            Console.WriteLine("El resultado de la suma es {0}", suma(num1, num2));
        }

        static int suma(int a, int b)
        {
            return a + b;
        }
    }
}