using System;
namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            // num = (365*2=730) + (30*2=60) + (7*2=14) + (3days)
            int num = 807; 
            int year = 365;
            int month = 30;
            int week = 7;

            int yearNum = num / year;
            int yearRest = num % year;

            int monthNum = yearRest / month;
            int monthRest = yearRest % month;

            int weekNum = monthRest / week;
            int weekRest = monthRest % week;

            


            Console.WriteLine( yearNum + " years");
            Console.WriteLine(monthNum + " months");
            Console.WriteLine(weekNum + " weeks");
            Console.WriteLine(weekRest + " da");

        }
    }
}
