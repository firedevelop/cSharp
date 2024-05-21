namespace cSharp
{
    public class VT10_05_Examen
    {
        public static void Print()
        {
            // string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt"; // No utilizado
            int i, j, spc, rows, k;
            Console.WriteLine("\n\n");
            Console.WriteLine("------");
            Console.WriteLine("Introduce el numero de filas: ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" "); // Cambiado de WriteLine a Write para imprimir espacios en la misma línea
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* "); // Cambiado de WriteLine a Write para imprimir asteriscos en la misma línea
                }
                Console.WriteLine(); // Nueva línea después de cada fila
                spc--;
            }
        }



    }
}

/* output:



------
Introduce el numero de filas:
5
*/
















*








*
*







*
*
*






*
*
*
*


*/

