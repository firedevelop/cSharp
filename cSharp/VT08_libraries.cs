using System;
namespace cSharp
{
    internal class VT08_libraries
    {
            public static void Print()
            {
            // Abs(): Calcula el valor absoluto de un número.
            int absoluteValue = Math.Abs(-10);
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
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Número aleatorio entre 1 y 100
            Console.WriteLine($"Número aleatorio: {randomNumber}");
        }

    }
}