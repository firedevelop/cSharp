namespace cSharp
{
    public class VT10_00_FileStream
    {
        public static void Print()
        {
            static void LeerFichero(string ruta)
            {
                // Se establecen los recursos para la lectura/escritura: un fichero y un flujo (stream)
                FileStream F1 = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader F1_Reader = new StreamReader(F1);

                // Se lee del fichero
                string Registro = "";
                while ((Registro = F1_Reader.ReadLine()) != null)
                {
                    Console.WriteLine(Registro);
                }

                // Se liberan los recursos
                F1_Reader.Close();
                F1.Close();
            }

            static void EscribirFichero(string Ruta, string Registro)
            {
                // Se establecen los recursos para la lectura/escritura: un fichero y un flujo (stream)
                FileStream F1 = new FileStream(Ruta, FileMode.Append, FileAccess.Write);
                StreamWriter F1_Writer = new StreamWriter(F1);

                // Se escribe el fichero
                F1_Writer.WriteLine(Registro);

                // Se liberan los recursos
                F1_Writer.Close();
                F1.Close();
            }

            static void Main(string[] args)
            {
                // Se establece el nombre del fichero
                string RutaArchivo = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";

                // Establecemos un bucle que será infinito siempre que se responda L (Leer) o E (Escribir)
                while (true)
                {
                    Console.WriteLine("Quieres leer el fichero o añadir un alumno? (L/E): ");
                    string Respuesta = Console.ReadLine();

                    if (Respuesta.ToUpper() == "L")
                    {
                        LeerFichero(RutaArchivo);
                    }
                    else if (Respuesta.ToUpper() == "E")
                    {
                        Console.Write("Escribe el nombre del alumno: ");

                        string Alumno = Console.ReadLine();

                        EscribirFichero(RutaArchivo, Alumno);
                        Console.WriteLine();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }


}