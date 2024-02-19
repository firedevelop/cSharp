using System;
public class Casting
{
    public static void Print()
    {
        Console.WriteLine("CONVERSION EXPLICITA");
        double a = 2.99;
        int b;
        b = (int)a; 
        Console.WriteLine(b); // output 2. Perdida de información. Casting


	}
}