namespace cSharp
{
    public class VT10_09_Examen
    {
        public static void Print()
        {
            string pathFile = "C:\\Users\\it77\\Documents\\GitHub\\cSharp\\cSharp\\1.txt";
            FileStream fichero = new FileStream(pathFile, FileMode.Create, FileAccess.Write);
            StreamWriter fs = new StreamWriter(fichero);
            int num1, num2, aux;
            Console.WriteLine("App to save numbers in a txt file.");
            do
            {
                
                Console.WriteLine("Introduce un numero 1 (Press 0 to stop): ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un numero 2  (Press 0 to stop): ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 != 0 && num2 != 0)
                {
                    if (num1 > num2)
                    {
                        aux = num1;
                        num1 = num2;
                        num2 = aux;
                    }
                    fs.WriteLine("{0} {1}", num1, num2);
                }
            } while (num1 != 0 || num2 != 0);
            fs.Close();
            fichero.Close();
        }
    }
}



/* output:
App to save numbers in a txt file.
Introduce un numero 1 (Press 0 to stop):
10

Introduce un numero 2  (Press 0 to stop):
20

Introduce un numero 1 (Press 0 to stop):
0

Introduce un numero 2  (Press 0 to stop):
0

*/
