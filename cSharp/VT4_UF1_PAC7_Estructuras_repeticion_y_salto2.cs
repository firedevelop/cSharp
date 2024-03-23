using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace cSharp
{
    public class VT4_UF1_PAC7_Estructuras_repeticion_y_salto2
    {
        public static void Print()
        {
            /*

                       // MATRIZ BIDIMENSIONAL. 
                       // int[,] declaracion de matriz bidimensional
                       int[,] matriz = new int[10, 10];
                       for (int i = 0; i < 10; i++)
                       {
                           for (int j = 0; j < 10; j++)
                           {
                               matriz[i, j] = i * 10 + j + 1;
                               Console.WriteLine("{0}", matriz[i, j]);
                           }
                       }
                       Console.ReadKey();


            // ADIVINA NUMERP RAMDOM
            Random aleatorio = new Random();
            int adivinar = aleatorio.Next(0, 10); // Rango [0, 9]
            int numero;
            for (int i = 0; i < 10; i++) // Hasta 10 intentos
            {
                Console.WriteLine("Quedan {0} intentos.", 10 - i);
                Console.WriteLine("Introduce un número:");
                numero = int.Parse(Console.ReadLine());
                if (adivinar == numero)
                {
                    Console.WriteLine("¡Lo adivinaste!");
                    break; // Salir del bucle si se adivina el número
                }
            }
            Console.ReadKey(); 


            // SUM ARRAY UNTIL FIND NUMBER
            int suma = 0;
            int[] array = { 1, 2, 3, 5, 7, 43, 56, 34, 21, 87, 12, 67, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 7)
                {
                    break;
                }
                suma += array[i];
            }
            Console.WriteLine("{0}", suma);
            Console.ReadKey();
            // ARRAY CONTINUE
            // 43+56+34+21+87+12+67 = 320
            int suma = 0;
            int[] array = { 1, 2, 3, 5, 7, 43, 56, 34, 21, 87, 12, 67, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 10)
                {
                    continue;
                }
                suma += array[i];
            }
            Console.WriteLine("{0}", suma);
            Console.ReadKey();
            string frase = "Hola mundo";
            bool contieneHola = frase.Contains("Hola");
            Console.WriteLine(contieneHola);  // Resultado: true
            string frase = "Hola mundo";
            int posicion = frase.IndexOf("mundo");
            Console.WriteLine(posicion);  // Resultado: 5 (posición de la primera letra de "mundo")
            string textoConEspacios = "    Hola     ";
            string textoSinEspacios = textoConEspacios.Trim();
            Console.WriteLine(textoSinEspacios);  // Resultado: "Hola"
            string frase = "Hola,mundo,C#,programacion";
            string[] palabras = frase.Split(',');
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            // Resultado:
            // Hola
            // mundo
            // C#
            // programacion
            string frase = "Hola mundo";
            string nuevaFrase = frase.Remove(4);  // Elimina desde la posición 4 hasta el final
            Console.WriteLine(nuevaFrase);  // Resultado: "Hola"


            // BREAK IN ACTION
            //In this example, we have an outer loop and an inner loop.The inner loop will break when i is equal to 2 and j is equal to 2.This break statement only exits the inner loop and continues with the next iteration of the outer loop.
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer loop iteration: " + i);
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("  Inner loop iteration: " + j);
                    if (i == 2 && j == 2)
                    {
                        Console.WriteLine("    Breaking inner loop...");
                        break; // Breaks only the inner loop
     
            
            }
                }
            }
            Console.WriteLine("Outside of loops");

            int adivinar, numero;
            Random aleatorio = new Random();
            adivinar = aleatorio.Next(0, 9);
            Console.WriteLine(adivinar);

            for (int i = 0; i <=9; i++)
            {
                Console.WriteLine("Queda {0} intentos.", 10 - i);
                Console.WriteLine("Introduce un número");
                numero = int.Parse(Console.ReadLine());
                if (adivinar == numero)
                {
                    Console.WriteLine("Lo adivinaste!");
                    break;
                }
            }
*/
        }
    }
}