using System;
using System.ComponentModel;
using System.IO;
namespace cSharp
{
    public class VT09_FileStream_Byte_Read
    {
        public static void Print()
            // Lee Bytes
        {   // output 49. corresponde al valos ASCII del caracter 1
            // cat 1 >> 2.txt
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";
            string pathFile2 = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\2.txt";
            FileStream fichero = new FileStream(pathFile2, FileMode.Open, FileAccess.Read);
            Byte[] buffer = new byte[fichero.Length]; //un entero de 8 bits sin signo.
            fichero.Read(buffer, 0, buffer.Length); // abrimos y recorremos bytes del fichero
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.WriteLine(buffer[i]);
            }
            Console.WriteLine("fichero.Length: " + fichero.Length);
            fichero.Close();

        }
    }
}