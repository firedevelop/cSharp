namespace cSharp
{
    public class VT10_08_Examen
    {

        int[,] x;
        VT10_08_Examen()
        {
            x = new int[,]
            {
                    {11, 2, 61 },
                    {42, 50, 3}
            };
        }
        void printarray()
        {
            Console.WriteLine("Elements in the Given Matrix: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(x[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        int max()
        {
            int small = x[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (small > x[i, j])
                    {
                        small = x[i, j];
                    }
                }
            }
            return small;
        }
        public static void Print()
        {
            VT10_08_Examen obj = new VT10_08_Examen();
            obj.printarray();
            Console.WriteLine("Smallest Element: {0}", obj.max());
            Console.ReadLine();
        }
    }

}



/* output:
 * 
Elements in the Given Matrix:
11
2
61


42
50
3


Smallest Element: 2

*/
