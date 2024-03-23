namespace cSharp
{
    public class c012_random_array
    {
        public static void Print()
        {

            // El siguiente programa crea un array de 10 números aleatorios entre 0 y 100, y muestra la media de estos números
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

        }
    }
}