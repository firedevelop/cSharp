using System;
public class Conversion_Explicita_Implicita_int_double
{
    public static void Print()
    {
        int a = 1;
        double b = a;
        Console.WriteLine(b);
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());

        double c = 2.99;
        int d = (int)c;
        Console.WriteLine(d);
    }
}