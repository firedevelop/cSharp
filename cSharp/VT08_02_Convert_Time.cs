using System;
namespace cSharp
{
    internal class VT08_02_Convert_Time
    {
        public static void Print()
        {
            string opcion = "";

            do
            {
                Console.WriteLine("Operación 1: convertir a horas-minutos-segundos.");
                Console.WriteLine("Operación 2: convertir a segundos.");
                Console.Write("Selecciona una opción: ");

                opcion = Console.ReadLine();

                switch (opcion) 
                {
                    case "1":
                        opcion01();
                        break;
                    case "2":
                        opcion02();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion == "1" || opcion == "2");
        }

        public static void opcion01()
        {
            // Convertir de segundos a horas-minutos-segundos
            Console.Write("Introduce el número de segundos a convertir: ");
            int in_segundos = Int32.Parse(Console.ReadLine());

            int out_horas = in_segundos / 3600;
            in_segundos = in_segundos % 3600;

            int out_minutos = in_segundos / 60;
            int out_segundos = in_segundos % 60;

            Console.WriteLine("");
            Console.WriteLine("El resultado es {0} horas, {1} minutos y {2} segundos.", out_horas, out_minutos, out_segundos);
            Console.WriteLine("");

        }

        public static void opcion02()
        {
            // Convertir de horas-minutos-segundos a segundos
            Console.Write("Introduce el número de horas a convertir: ");
            int in_horas = Int32.Parse(Console.ReadLine());

            Console.Write("Introduce el número de minutos a convertir: ");
            int in_minutos = Int32.Parse(Console.ReadLine());

            Console.Write("Introduce el número de segundos a convertir: ");
            int in_segundos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + ((in_horas * 3600) + (in_minutos * 60) + (in_segundos)) + " segundos.");
        }

        /* input seconds and get how many hours, minuts, seconds.
         // 3721 = 3 hour(60*60*3=10800) + 5 minuts (60*5=300) + 7 second
        int secondsInput = 11107;

        int seconds = 60;
        int minuts = 60;
        int minutsCalc;
        int hoursCalc = 0;
        int minutsRest = 0;

        int secondsRest = 0;

        minutsCalc = secondsInput / minuts;
            if (minutsCalc >= minuts)
            {
                hoursCalc = minutsCalc / minuts; 
                minutsRest = minutsCalc % minuts;
                secondsRest = secondsInput - ((hoursCalc* minuts * seconds) + (minutsRest* seconds));
            }

    Console.WriteLine("hours: " + hoursCalc);
            Console.WriteLine("minutsRest: " + minutsRest);
            Console.WriteLine("seconds: " + secondsRest);
        */
    }
}