namespace cSharp
{
    public class VT11_Examen_UF1
    {
        public static void Print()
        {
            Console.WriteLine("\n====== UF1 - PAC extraordinaria ======");
            Console.WriteLine("=== 1. ¿Qué imprimirá en la consola este código?");
            int num = 20;
            string result = (num % 2 == 0) ? "Par" : "Impar";
            Console.WriteLine(result);

            Console.WriteLine("=== 2.1. Lamba | LINQ (Language Integrated Query)");
            int[] array2 = { 1, 2, 3, 4, 5 };
            int count = array2.Count(x => x % 2 == 0);
            Console.WriteLine(count);

            Console.WriteLine("=== 2.2. for");
            int count2 = 0;
            for (int x = 0; x < array2.Length; x++)
            {
                if (array2[x] % 2 == 0)
                {
                    count2++;
                }
            }
            Console.WriteLine(count2);

            Console.WriteLine("=== 3. String literal interpolation");
            int num1 = 10, num2 = 20;
            Console.WriteLine($" {num1} + {num2} = {num1 + num2}");
            // 10 + 20 = 30

            Console.WriteLine("=== 4. Reverse");
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            // 5 4 3 2 1

            Console.WriteLine("=== 5. Split");
            string text = "Hello World !";
            string[] words = text.Split(' ');
            Console.WriteLine(words[2]); // a

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("=== 6. ternary conditional operator");
            int num6 = 30;
            string result6 = (num6 % 5 == 0) ?
                            ((num6 % 3 == 0) ? "Divisible por 5 y 3" : "Divisible por 5") :
                                "No divisible por 5";

            Console.WriteLine(result6);
            // Divisible por 5 y 3

            Console.WriteLine("=== 9.1 two-dimensional array (matrix) 3x4  ");
            int[,] array1 = { { 1, 2, 3, 4 }, 
                              { 5, 6, 7, 8 }, 
                              { 9, 10, 11, 12 } };

            for (int i = 0; i < array1.GetLength(0); i++) // 0 means get number rows
            {
                for (int j = 0; j < array1.GetLength(1); j++) // 1 means get number columns
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(array1[2, 1]);


            Console.WriteLine("=== 11. Errores en declaraciones");
            // bool flag = true:
            int division = 6 / 2; Console.WriteLine(division);
            int division2 = 7 / 3; Console.WriteLine(division2);
            bool mayor = 5 > 3; Console.WriteLine(mayor);
            // int igual = 4 == 6;  Error compilacion
            // int numero == 6;     Error compilacion
            //  int suma = ++4;     Error compilacion
            //  int suma2 = 4++5;   Error compilacion
            //  int suma2 = 4++ 5;  Error compilacion

            Console.WriteLine("=== 12. Random");
            int[] array = new int[10];
            Random aleatorio = new Random();
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = aleatorio.Next(0, 100);
                suma += array[i];
            }
            Console.WriteLine("La media es {0}", suma / array.Length);
            Console.ReadKey();


            Console.WriteLine("=== 13. Tipos numericos integrales y punto flotante");
            // https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

            // https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            Console.WriteLine("=== 12. Adivina Guess Number");
            int adivinar, numero;
            Random aleatorio1 = new Random();
            adivinar = aleatorio1.Next(0, 9);
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Queda {0} intentos.", 10 - i);
                Console.WriteLine("Introduce un número");
                numero = int.Parse(Console.ReadLine());
                if (adivinar == numero)
                {
                    Console.WriteLine("Lo adivinaste!");
                    break;
                }
            }


            Console.WriteLine("=== 19. String Methods");
            // Sample string
            string text2 = "Hello, World!";

            // 1. Contains()
            bool contains = text.Contains("Hello");
            Console.WriteLine($"Contains 'Hello': {contains}");

            // 2. IndexOf()
            int index = text.IndexOf("World");
            Console.WriteLine($"Index of 'World': {index}");

            // 3. Trim()
            string trimmedText = text.Trim();
            Console.WriteLine($"Trimmed text2: '{trimmedText}'");

            // 4. Split()
            string[] splitArray = text.Split(',');
            Console.WriteLine("Split text2:");
            foreach (var part in splitArray)
            {
                Console.WriteLine(part);
            }

            // 5. Remove()
            string removedText = text.Remove(5, 5);
            Console.WriteLine($"Text after removing: '{removedText}'");

            // 6. ToLower()
            string lowercaseText = text.ToLower();
            Console.WriteLine($"Lowercase text2: '{lowercaseText}'");

            // 7. ToUpper()
            string uppercaseText = text.ToUpper();
            Console.WriteLine($"Uppercase text2: '{uppercaseText}'");


            Console.WriteLine("=== 22. Matrix");
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5 };
            matrix[2] = new int[] { 6, 7, 8, 9 };
            Console.WriteLine(matrix[1].Length);
            // 2
        }
    }
    }


/* output:


*/

