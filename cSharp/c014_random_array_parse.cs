namespace cSharp
{
    public class c014_random_array_parse
    {
        public static void Print()
        {
            Random aleatorio = new Random();
            int adivinar = 1;
            int numero;
            Console.WriteLine(adivinar);
            for (int i = 0; i < 9; i++) // [2]
            {
                Console.WriteLine("Quedan {0} intentos.", 9 - i); // [3]
                Console.WriteLine("Introduce un n�mero:");
                numero = int.Parse(Console.ReadLine());
                if (adivinar == numero)
                {
                    Console.WriteLine("�Lo adivinaste!");
                    break;
                }
            }
            Console.ReadKey();
        }

    }
}

// [1] Rango [0, 8]. The nine is not included.
// [2] Hasta 10 intentos
// [3] better use the number "9 - i" if not you allow 10 times to the user instead of 9.