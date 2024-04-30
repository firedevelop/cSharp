using System;
using System.IO;
namespace cSharp
{
    public class Test
    {
        public static void Print()
        {
            /* En el método MAIN(): preguntar al usuario si quiere ahadir algün alumno al fichero alumnos.txt o leer el fichero.
              * Crear Método 1: Si el usuario decide leer el fichero, muestra el contenido de alumnos.txt
              * Crear Método 2: Si el usuario decide ahadir algün alumno, preguntar su nombre y ahadirlo a alumnos.txt FileStream
              * Proporciona un Stream para un archivo, Io que permite operaciones
              de lectura y escritura sincrönica y asincrönica */
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";

            Console.WriteLine("Would you like: \n[1] Read names \n[2] Add name");
            int userSelection = int.Parse(Console.ReadLine());
            if (userSelection == 1)
            {
                FileStream fichero = new FileStream(pathFile, FileMode.Open, FileAccess.Read);
                StreamReader fs = new StreamReader(fichero);
                string linea = "";
                while (( linea = fs.ReadLine()) != null) {
                    Console.WriteLine(linea);
                }
                fs.Close();
                fichero.Close();
            }
            else
            {
                FileStream fichero = new FileStream(pathFile, FileMode.Append, FileAccess.Write);
                StreamWriter fs = new StreamWriter(fichero);
                Console.Write("Add name: ");
                string name = Console.ReadLine();
                fs.WriteLine(name);
                fs.Close();
                fichero.Close();
            }
        }

    }
}
