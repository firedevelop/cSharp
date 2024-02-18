class myContinue
{
    public static void PrintMyContinue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i < 9)
            {
                continue;
            }
        }
        string frase = "buenos días";
        Console.WriteLine("El caracter de la posición 5, es {0}", frase[5]);
    }
}