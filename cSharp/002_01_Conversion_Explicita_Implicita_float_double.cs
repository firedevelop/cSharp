public class Conversion_Explicita_Implicita_float_double
{
    public static void Print()
    {
        float a = 3.14F;
        double b = a;
        Console.WriteLine(b);
        Console.WriteLine($"{b:F7}");

        double c = 3.123456789;
        float d = (float)c;
        Console.WriteLine(d);
    }
}