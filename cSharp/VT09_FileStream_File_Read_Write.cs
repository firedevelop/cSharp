using System;
using System.IO;

namespace cSharp
{
    public class VT09_FileStream_File_Read_Write
    {
        public static void Print()
        {
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";

            try
            {
                // Write File
                using (FileStream fichero2 = new FileStream(pathFile, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter fs2 = new StreamWriter(fichero2))
                    {
                        string frase2 = Console.ReadLine();
                        fs2.WriteLine(frase2);
                    }
                }

                // Read File
                using (FileStream fichero = new FileStream(pathFile, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader fs = new StreamReader(fichero))
                    {
                        string linea = "";
                        while ((linea = fs.ReadLine()) != null)
                        {
                            Console.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
