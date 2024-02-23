using System;
public class Conversion_Parse_String_Int
{
    public static void Print()
    {
        int a = 1;
        string b = "2";
        Console.WriteLine(a + b);
        Console.WriteLine(a + int.Parse(b));
    }
}