using System;
using System.IO;
namespace cSharp
{
    public class VT10_04_Examen
    {
        public static void Print()
        {
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";
            FileStream fichero = new FileStream(pathFile, FileMode.Open, FileAccess.Read);
            StreamReader fs = new StreamReader(fichero);

            String linea = "";
            int contadorLineas = 0,
                contador = 0,
                contadorA = 0,
                contadorLineasA = 0;

            while ((linea = fs.ReadLine()) != null)
            {
                contadorLineas++;
                if (linea.Length < 50)
                {
                    contador++;
                }
                for (int i = 0; i < linea.Length; i++)
                {
                    if (linea[i] == 'A')
                    {
                        contadorA++;
                    }
                }
                if (contadorA >= 1)
                {
                    contadorLineasA++;
                }
                contadorA = 0;
            }
            fs.Close();
            fichero.Close();
            Console.WriteLine("Tiene {0} lineas", contadorLineas);
            Console.WriteLine("Tiene {0} lineas con menos de 50 caracter", contador);
            Console.WriteLine("Tiene {0} lineas con la letra A", contadorLineasA);
        }
    }
}

/* output:
Tiene 1 lineas
Tiene 1 lineas con menos de 50 caracter
Tiene 1 lineas con la letra A
*/