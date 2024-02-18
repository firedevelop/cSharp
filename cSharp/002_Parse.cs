using System.IO;
using System;
class cs002
{
    static void Main2()
    {
        Console.WriteLine("\n CONVERT STRINºG TO INT");
        var str1 = "2";
        var str2 = "3";
        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);
        var sum = num1 + num2;
        Console.WriteLine(sum);

        Console.WriteLine("\n CONVERT STRING TO DECIMAL");
        var decimal1 = decimal.Parse("2.5");
        var decimal2 = 4.5m; // "m" Explicitly convert from int to decimal
        var sum2 = decimal1 + decimal2;

        Console.WriteLine(sum2);

        Console.WriteLine("\n CONVERT STRING TO DATE");
        var date1 = DateTime.Parse("2023-01-01");
        var date2 = date1.AddDays(1);
        Console.WriteLine($"Date: {date2}");
    }
}