class Arrays
{
    public static void PrintArray()
    {
        char[] abc = { 'a', 'd', 'i', 'p', 'm' };
        int[] num = new int[3] { 1, 2, 3 };
        string[] cycle = new string[] { "analisys", "diseño", "implementacion", "pruebas", "mantenimiento" };

        foreach (char item in abc)
        {
            Console.WriteLine(item);
        }
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }
        int x = 0;
        while (x < cycle.Length)
        {
            Console.WriteLine(cycle[x]);
            x++;
        }
    }
}