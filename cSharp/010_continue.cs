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
        string frase = "buenos d�as";
        Console.WriteLine("El caracter de la posici�n 5, es {0}", frase[5]);
    }
}