using System;
public class cs001
{
    public static void Main2()
    {
        Console.WriteLine("____ ^");
        Console.WriteLine(true  ^ true);    // False
        Console.WriteLine(true  ^ false);   // True
        Console.WriteLine(false ^ true);    // True
        Console.WriteLine(false ^ false);   // False

        Console.WriteLine("____ &");
        Console.WriteLine(true  & true);    // True
        Console.WriteLine(true  & false);   // False
        Console.WriteLine(false & true);    // False
        Console.WriteLine(false & false);   // False
        Console.WriteLine(null  & true);    // 
        Console.WriteLine(null  & false);   // False
        Console.WriteLine(true  & null);    // 
        Console.WriteLine(false & null);    // False

        Console.WriteLine("____ |");
        Console.WriteLine(true  | true);    // True
        Console.WriteLine(true  | false);   // True
        Console.WriteLine(false | true);    // True
        Console.WriteLine(false | false);   // False
        Console.WriteLine(null  | true);    // True
        Console.WriteLine(null  | false);   // 
        Console.WriteLine(true  | null);    // True
        Console.WriteLine(false | null);    // 

        Console.WriteLine("____ &&");
        Console.WriteLine(true  && true);   // True
        Console.WriteLine(true  && false);  // False
        Console.WriteLine(false && true);   // False
        Console.WriteLine(false && false);  // False

        Console.WriteLine("____ ||");
        Console.WriteLine(true  || true);   // True
        Console.WriteLine(true  || false);  // True
        Console.WriteLine(false || true);   // True
        Console.WriteLine(false || false);  // False

    }
}