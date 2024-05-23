using System;
namespace cSharp
{
    internal class VT08_libraries
    {
            public static void Print()
            {

            // Tipo String Trim. Quita todos los caracteres de espacio en blanco del principio y el final de la cadena actual.

            // Tipo String Contains. Devuelve un valor que indica si una subcadenaespecificada aparece dentro de esta cadena.
            String text = "Hello world!";
            bool textCheck = text.Contains("!");
            Console.WriteLine(textCheck);

            // Tipo String Substring. Recupera una subcadenade la instancia.
            string textGet = text.Substring(1, 4);
            Console.WriteLine(textGet); // ello
            // Tipo String ToLower. Devuelve una copia de la cadena convertida en minúsculas.

            // Tipo String ToUpper. Devuelve una copia de la cadena convertida en Mayúsculas.




            // Truncate() elimina parte decimal
            double numTruncate = 32.5487;
            Console.WriteLine(Math.Truncate(numTruncate)); // 32

            // Abs(): Calcula el valor absoluto de un número.
            int absoluteValue = Math.Abs(-10); // 10
            Console.WriteLine($"El valor absoluto es {absoluteValue}");

            // Pow(): Calcula la potencia de un número.
            double baseNumber = 2;
            double exponent = 3;
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} elevado a la potencia {exponent} es igual a {result}");

            // Sqrt(): Calcula la raíz cuadrada de un número.
            double squareRoot = Math.Sqrt(16);
            Console.WriteLine($"La raíz cuadrada de 16 es {squareRoot}");

            // Log(): Calcula el logaritmo natural de un número.
            double logarithm = Math.Log(10);
            Console.WriteLine($"El logaritmo natural de 10 es {logarithm}");

            // Split(): Divide una cadena en subcadenas utilizando un delimitador específico.
            string sentence = "Hola, cómo estás?";
            string[] words = sentence.Split(' ');
            Console.WriteLine($"La frase tiene {words.Length} palabras: " + words[0] + " and " + words[1]);
           
            // IndexOf(): Encuentra la posición de la primera aparición de un carácter en una cadena.
            string str = "Hello World";
            int index = str.IndexOf('W');
            Console.WriteLine($"La posición de 'W' en '{str}' es {index}");

            // Now(): Obtiene la fecha y hora actuales.
            DateTime now = DateTime.Now;
            Console.WriteLine($"La fecha y hora actual es: {now}");

            // IsDigit(): Verifica si un carácter es un dígito.
            char character = '9';
            bool isDigit = char.IsDigit(character);
            Console.WriteLine($"¿El carácter '{character}' es un dígito? {isDigit}");

            // Next(): Genera un número entero aleatorio dentro de un rango especificado.
            Random rnd = new Random();
            Console.WriteLine("\n20 random integers from - 100 to 100:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(-100, 101));
                if (ctr % 5 == 0) Console.WriteLine(); // Multiplos de 5, se usa para que haga salto de linea
            }
            Console.WriteLine("\n20 random integers from 1000 to 10000:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,8}", rnd.Next(1000, 10001));
                if (ctr % 5 == 0) Console.WriteLine();
            }
            Console.WriteLine("\n20 random integers from 1 to 10:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(1, 11));
                if (ctr % 5 == 0) Console.WriteLine();
            }
        }

    }
}