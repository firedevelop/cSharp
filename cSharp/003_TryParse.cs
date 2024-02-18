using System;
class cs003
{
    public static void Main3(string[] args)
    {

        Console.WriteLine("intro num1");
        string str1 = Console.ReadLine();

        Console.WriteLine("intro num2");
        string str2 = Console.ReadLine();

        int num1, num2;
        bool result1 = int.TryParse(str1, out num1);
        bool result2 = int.TryParse(str2, out num2);

        if (result1 && result2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}