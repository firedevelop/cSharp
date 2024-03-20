using System;
public class test
{
    public static void Print()
    {
        int a = 1;
        string b = "2";
        string c = "2";
        Console.WriteLine(a + b + c);
        Console.WriteLine(a + int.Parse(b) + int.Parse(c));

    }
}