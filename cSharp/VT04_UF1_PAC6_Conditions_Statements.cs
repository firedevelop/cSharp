namespace cSharp
{
    public class VT4_UF1_PAC6_Conditions_Statements
    {
        public static void Print()
        {
            /**********************/
            for (int i = 1; i <= 10; i++)
            { Console.WriteLine("{0}", i); } // 1 2 3 4 5 6 7 8 9 10}


            /**********************/
            for (int j = 10; j >= 1; j--)
            { Console.WriteLine("{0}", j); } //10 9 8 7 6 5 4 3 2 1


            /**********************/
            double num;
            do
            {
                Console.WriteLine("Introduce un número:");
                num = Double.Parse(Console.ReadLine());
                if (num > 0)
                    Console.WriteLine("POSITIVO");
                else if (num < 0)
                    Console.WriteLine("NEGATIVO");
            } while (num != 0);
            Console.ReadKey();


            /**********************/
            int num1;
            int cont = 0;
            int sum = 0;
            double media;
            do
            {
                Console.WriteLine("Introduce notas:");
                num1 = int.Parse(Console.ReadLine());
                if (num1 != 0)
                {
                    cont++;
                    sum += num1;
                }
            }
            while (num1 != 0);
            media = sum / cont;
            Console.WriteLine("tus nota media es {0}", media);
            Console.ReadKey();
        }
    }
}