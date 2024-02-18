using System;
class DaysWeek
{
    public enum Days
    {
        Monday, Tuesday, Wendnesday, Thursday, Friday, Saturday, Sunday
    }

    public static void PrintDays()
    {
        int x = (int)Days.Monday;
        int y = (int)Days.Sunday;
        Console.WriteLine("Lunes = {0}", x);
        Console.WriteLine("Domingo = {0}", y);
    }
}
