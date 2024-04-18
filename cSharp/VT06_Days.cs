using System;
namespace cSharp
{
    public class VT06_Days
    {
        public static void Print()
        {
            Console.Write("Inserta el número de días: ");
            int numDias = int.Parse(Console.ReadLine());

            int anyos = numDias / 365;
            int restoDias = numDias % 365;

            int meses = restoDias / 30;
            restoDias = restoDias % 30;

            int semanas = restoDias / 7;
            restoDias = restoDias % 7;

            Console.WriteLine(numDias + " días son: " + anyos + " años, " + meses + " meses, " + semanas + " semanas y " + restoDias + " días." );
            Console.WriteLine("{0} días son: {1} años, {2} meses, {3} semanas y {4} días.", numDias, anyos, meses, semanas, restoDias);
        }

    }
}