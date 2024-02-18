using System;
public class Variables
{
    public static void PrintVariables()
    {
        Console.WriteLine(5 * 2);       // 35
            Console.WriteLine(5.0 / 2.0);   // 2.5
            Console.WriteLine(5 / 2);       // 2
            Console.WriteLine(5 / 2.0);       // 2.5
            Console.WriteLine(10 % 3);      // 1
            int edad = 18;
            Console.WriteLine("Edad: " + edad);           // Edad: 18
            edad++;
            Console.WriteLine("Edad: " + edad + " años"); // Edad: 19 años

            Console.WriteLine(++edad);  // 20
            Console.WriteLine(edad++);  // 20

        /* https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/addition-operator
        */
            Console.WriteLine("\n***** DECLARACIONES EXPLICITA");

            Console.WriteLine("\nDECLARAR Y DESPUES INICIALIZAR");
            int a1; // declarar variable tipo int
            a1 = 2; // inicializar variable
            Console.WriteLine(a1);

            Console.WriteLine("\nDECLARAR E INICIALIZAR EN MISMA LINEA");
            int a2 = 2;
            Console.WriteLine(a2);


            /*          ERROR al volver a Declarar
                        int a = 3;
                        Console.WriteLine(a);
            */

            // Asignar Nuevo valor
            a2 = 3;
            Console.WriteLine(a2);

            Console.WriteLine("\nMULTIPLES DECLARACIONES");
            int b1;
            int b2;
            int b3;
            b1 = b2 = b3 = 3;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            Console.WriteLine("\nDECLARAR E INICIALIZAR EN MISMA LINEA");
            int c1, c2, c3 = 8;
            //          Console.WriteLine(c1);  ERROR DECLARA PERO NO INICIALIZADA
            //          Console.WriteLine(c2);  ERROR DECLARA PERO NO INICIALIZADA
            Console.WriteLine(c3); // 8     OK DECLARADA E INICIALIZADA

            //          Console.WriteLine(c1.GetType());    Aunque c1 está declarada como una variable de tipo int, el compilador no le asigna automáticamente un valor inicial, por lo que técnicamente no está inicializada en ese punto.
            Console.WriteLine(c3.GetType()); // int

            c1 = 9; Console.WriteLine(c1);  // 9
            c2 = 10; Console.WriteLine(c2); // 10


            Console.WriteLine("\nDECLARACION POSIBLE PERO MENOS LEGIBLE");
            int d1, d2;
            Console.WriteLine(d1 = 11);
            Console.WriteLine(d2 = 12);
            //          Console.WriteLine(int d3 = 13);  ERROR DECLARAR EN MISMA LINEA 

            Console.WriteLine("\n***** DECLARACIONES IMPLICITA");
            // el compilador infiere el tipo de la variable basándose en el tipo de valor con el que se inicializa.

            var e1 = 2;  // int e1 = 2;
            Console.WriteLine(e1); // 2
            Console.WriteLine(e1.GetType());    //int

            var e2 = 2.5;
            Console.WriteLine(e2);
            Console.WriteLine(e2.GetType());    // double

            //          var e1 = 1.5;  ERROR no se puede declarar 2 veces
            //          e1 = 1.5;  ERROR no se puede cambiar el tipo.

            /* 
            Ventajas de tener tipos de variables estaticos en C#
            1. Mantenimiento del tipo de datos
            2. Legibilidad del código
            3. Prevención de errores
            4. Optimización del rendimiento
                4.1.  el conocimiento estático del tipo de variables puede ser aprovechado por el compilador para mejorar el rendimiento del código generado.
            */


            Console.WriteLine("\n EN DECLARACION IMPLICITA NO SE PUEDE DECLARAR EN 2 LINEAS COMO EN LA DECLARACION EXPLICITA");
            // int e3; int = 3; OK 
            // var e4;  ERROR
            // e4 = 3;  ERROR
            var e4 = 3; // OK

            Console.WriteLine("\n2. DECLARACIONES IMPLICITAS");
        }
    }

