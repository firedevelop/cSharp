using System;
using System.IO;
using System.Runtime.Versioning;
namespace cSharp
{
    public class VT09_FileStream_Byte_Write
    {
        public static void Print()
        {
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";
            // Vamos a trabajar con un fichero imagen, modificando su contenido. Primero lo abriremos de modo lectura y escritura
            FileStream fichero = new FileStream(pathFile, FileMode.Open, FileAccess.ReadWrite);
            // Creamos un buffer de tipo byte para poder trabajar con los datos del fichero
            Byte[] buffer = new byte[fichero.Length]; //un entero de 8 bits sin signo.
            // Abrimos el fichero para la lectura y vamos a ir consumiendo todos los bytes del fichero
            fichero.Read(buffer, 0, buffer.Length);
            // Ahora modificamos algunos bytes
            for (int i = 1000; i < buffer.Length; i++)
            {
                buffer[i] = 0;
            }
            // Vamos a sustituir los caracteres en el fichero, volcamos el contenido del buffer en el fichero y lo cerramos
            fichero.Write(buffer, 0, buffer.Length);
            fichero.Close();
        }
    }
}