namespace cSharp
{
    public class c015_break_vs_continue
    {
        public static void Print()
        {
            int sumBreak = 0;
            int sumContinue = 0;
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {
                    break;
                }
                sumBreak += array[i];
            }

            for (int j = 0; j < array.Length; j++)
            {

                if (array[j] == 3)
                {
                    continue;
                }
                sumContinue += array[j];
            }
            Console.WriteLine("Sum Break {0}", sumBreak);       // sumBreak = 1 + 2 + 3 = 6
            Console.WriteLine("Sum Continue {0}", sumContinue); // jump index array[3] = 4. sumContinue = 1 + 2 + 3 + 5 = 12
            Console.ReadKey();
        }
    }
}


