using System;

namespace PAC_Desarrollo_Entrega_2S2324
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Declaracion de variables
            string frase = "";
            string resultado = "";


            ////------------------------------------------------------------------------------------------ Ejecución libre del programa

            ////-------------------------- Se valida que la frase introducida sea correcta
            do
            {
                Console.Write("Inserta una frase para que la analice: ");
                frase = Console.ReadLine();

            } while (FraseValida(frase) == false);

            //-------------------------- Se obtiene la cuenta de caracteres mayúsculos, minúsculos, numéricos y otros
            resultado = ContarCaracteres(frase);
            Console.WriteLine(resultado);

            //-------------------------- Se obtiene la frase invertida
            resultado = InvertirFrase(frase);
            Console.WriteLine(resultado);

            //-------------------------- Se obtiene la primera posición donde aparece el número que más veces está en el array
            Console.WriteLine(CaracterMasRepetido(frase));

            //--- Fin de la ejecución del programa
        }

        public static bool FraseValida(string frase)
        {
            if(frase.Length >= 2 && frase.Length <= 10)
            {
                Console.WriteLine("La Frase introducida es válida");
                return true;
            } else
            {
                Console.WriteLine("Inténtelo de nuevo. La frase introducida debe estar comprendida entre 20 y 55 caracteres");
                return false;
            }
        }

        public static string ContarCaracteres(string frase)
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            foreach(char c in frase)
            {
                if (char.IsUpper(c))
                {
                    mayusculas++;
                } 
                else if(char.IsDigit(c))
                {
                    numeros++;
                } 
                else
                {
                    minusculas++;
                }
            }

            return "La frase contiene " + mayusculas + " letras mayúsculas, " + minusculas + " letras minúsculas y " + numeros + " números.";
        }

        public static string InvertirFrase(string frase)
        {
            char[] fraseToChar = frase.ToCharArray();
            Array.Reverse(fraseToChar);
            string resultado = new string(fraseToChar);
            return resultado;
        }

        public static string CaracterMasRepetido(string frase)
        {
            char[] arrLetras = new char[frase.Length];
            int[] arrContadorLetras = new int[frase.Length];
            int posicion;
            int contador;


            // ESPACIO DONDE EL ALUMNO DEBE IMPLEMENTAR LA SOLUCIÓN
           char[] fraseInvertida = InvertirFrase(frase).ToCharArray();
            contador = 1;
            posicion = 0;

            for (int i = 0; i < fraseInvertida.Length; i++)
            {
                for (int j = i + 1; j < fraseInvertida.Length; j++)
                {
                    if (fraseInvertida[i] == fraseInvertida[j])
                    {
                        Console.WriteLine("duplicate");
                        arrLetras[i] = fraseInvertida[i];
                        arrContadorLetras[i] = ++contador;
                        
                    }
                }
            }
            foreach (char c in arrLetras) { Console.WriteLine("arrLetras {0}", c); }
                foreach (char d in arrContadorLetras) { Console.WriteLine("arrContadorLetras {0}", d); }

            // FIN ES
            Console.WriteLine("contador = {0}",contador);
            if (contador > 1)
            {
                return "El valor '" + arrLetras[posicion - 1] + "' se repite " + arrContadorLetras[posicion - 1] + " veces y la primera vez que aparece en la frase es en la posición " + posicion + ".";
            }
            else
            {
                return "Todos los caracteres de la frase aparecen por igual.";
            }
        }
    }
}