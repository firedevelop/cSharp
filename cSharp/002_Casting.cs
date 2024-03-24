public class Casting
{
    public static void Print()
    {

        Console.WriteLine("\nCONVERSION IMPLICITA");
        int a = 1;
        double b = a;
        Console.Write(b);


        Console.WriteLine("\nCONVERSION EXPLICITA");
        double c = 2.99;
        int d = (int)c;
        Console.WriteLine(d); // output 2. Perdida de información. Casting. No es un redondeo
        Console.WriteLine(c);
        Console.Write(a.GetType());
        Console.Write(b.GetType());



    }
}