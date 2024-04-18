using System;
namespace cSharp
{
    internal class VT07_Array_Random
    {
        public static void Print()
        {
            //-------------- Ejercicio 1
            string[] arrayNombres = new string[5];
            double[] arraySalarios = new double[5];

            int posicion = 0;

            //--- Paso 01
            for (int i = 0; i < arrayNombres.Length; i++)
            {
                Console.Write("Escribe el nombre del empleado " + i + ": ");
                arrayNombres[i] = Console.ReadLine();

                Console.Write("Escribe el salario del empleado " + i + ": ");
                arraySalarios[i] = double.Parse(Console.ReadLine());
            }

            //--- Paso 02
            for (int i = 1; i < arrayNombres.Length; i++)
            {
                if (arraySalarios[posicion] < arraySalarios[i])
                {
                    posicion = i;
                }
            }

            //--- Paso 03
            Console.WriteLine("El empleado {0} tiene el mayor salario, y es {1} euros.", arrayNombres[posicion], arraySalarios[posicion]);
            Console.WriteLine("El empleado " + arrayNombres[posicion] + " tiene el mayor salario, y es " + arraySalarios[posicion] + " euros.");

            //----------------- Ejercicio 2
            int[,] matriz = new int[2, 3];

            Random aleatorio = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}