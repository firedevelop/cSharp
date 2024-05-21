using System.Security.Cryptography;

namespace cSharp
{
    public class VT11_Examen_UF2
    {
        public static void Print()
        {
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";

            Console.WriteLine("=== 1. Print Triangle");
            Print_Triangle();
            //  *
            //  **
            //  ***
            //  ****


            Console.WriteLine("=== 2. Factoriales");
            ImprimirFactoriales(5);
            // 1 2 6 24 120


            Console.WriteLine("=== 3. For array");
            int[] array3 = { 2, 4, 6, 8, 10 };
            BuscarValor(array3, 7);
            // No encontrado


            Console.WriteLine("=== 4. Double call function");
            int num4 = 2;
            Console.WriteLine(Doble(Doble(num4)));
            // 8


            Console.WriteLine("=== 5. Double call function");
            int num5 = Dividir(10, 3);
            Console.WriteLine(num5);


            Console.WriteLine("=== 9. FuncionMisteriosa");
            Console.WriteLine(FuncionMisteriosa(3, 4));


            Console.WriteLine("=== 14. ¿que devuelve?");
            Console.WriteLine(Cuadrado(3) + 5);


            Console.WriteLine("=== 15. MostrarCaracteres");
            string text15 = "ABCDEF";
            MostrarCaracteres(text15);

            string text16 = "Hello world!";
            string sub16 = text16.Substring(1);
            Console.WriteLine(sub16);

            string sub17 = text16.Substring(1);
            Console.WriteLine(sub17);


            Console.WriteLine("=== 1.UF3. StreamReader");
            StreamReader reader = new StreamReader(pathFile);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();


            Console.WriteLine("=== 7.UF3. StreamWrite");
            FileStream file = new FileStream(pathFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file); writer.Write("First line.");
            writer.WriteLine("Second line.");
            writer.Close();
            file.Close();

            StreamReader text7 = new StreamReader(pathFile);
            string content = text7.ReadToEnd();
            text7.Close();

            FileStream file8 = new FileStream(pathFile, FileMode.Append, FileAccess.Write);
            StreamWriter writer8 = new StreamWriter(file8);
            writer8.WriteLine("Additional note.");
            writer8.Close();
            file8.Close();
        }




        // === 1.
        public static void Print_Triangle()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }


        // === 2.
        static void ImprimirFactoriales(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{Factorial(i)} ");
            }
        }
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }


        // === 3.
        static void BuscarValor(int[] arr, int n)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {

                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "Encontrado" : "No encontrado");
        }


        // === 4.
        static int Doble(int num)
        {
            return num * 2;
        }


        // === 5.
        static int Dividir(int num5, int num6)
        {
            return num5 / num6;
        }


        // === 6.
        static int FuncionMisteriosa(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else if (b % 2 == 0)
                return FuncionMisteriosa(a * a, b / 2);
            else
                return a * FuncionMisteriosa(a * a, (b - 1) / 2);
        }


        // === 14.
        static int Cuadrado(int num)
        {
            return num * num;
        }



        // === 15.
        static void MostrarCaracteres(string str)
        {
            if (str.Length > 0)
            {
                Console.Write($"{str[0]} ");
                MostrarCaracteres(str.Substring(1));
            }
        }
    }
}