namespace cSharp
{
    public class c021_for_while_doWhile
    {
        public static void Print()
        {
            Console.WriteLine("Solución con bucle FOR");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1) // !=0
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Solución con bucle WHILE");
            int j = 1;

            while (j <= 10)
            {

                if (j % 2 == 1) // !=0
                    Console.WriteLine(j);
                {
                }

                j++;
            }
            Console.WriteLine("Solución con bucle DO-WHILE");

            int k = 1;
            do
            {
                if (k % 2 == 1) // !=0
                {
                    Console.WriteLine(k);
                }
                k++;
            } while (k <= 10);
        }
    }
}