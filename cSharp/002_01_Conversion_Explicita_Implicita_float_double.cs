using System;
public class Conversion_Explicita_Implicita_float_double
{
    public static void Print()
    {
        float c = 3.14F;
        Console.WriteLine(c);
        double d = c;
        Console.WriteLine(d);
       
        
        double b = 123.456;
        float a = (float)b;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}