namespace cSharp
{
    public class c013_two_dimensional_array
    {
        public static void Print()
        {
            // int[,] declaracion de matriz bidimensional
            int[,] matriz = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = i * 10 + j + 1;
                    Console.WriteLine("{0}", matriz[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}