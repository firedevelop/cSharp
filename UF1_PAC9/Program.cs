using System;

namespace PAC_Desarrollo_Entrega_2S2324
{
    public class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            Console.Write("Inserta una frase para que la analice: ");
            frase = Console.ReadLine();

            Console.WriteLine(CaracterMasRepetido(frase));
        }
        public static string CaracterMasRepetido(string frase)
        {
            char[] arrLetras = new char[frase.Length];
            int[] arrContadorLetras = new int[frase.Length];
            int posicion;
            int contador;

            // START YOUR OWN CODE

            // Inicializamos el contador y la posición
            contador = 0;
            posicion = 0;

            // Recorremos la frase caracter a caracter
            for (int i = 0; i < frase.Length; i++)
            {
                // Buscamos si el caracter actual ya se ha analizado
                posicion = Array.IndexOf(arrLetras, frase[i]);

                // Si el caracter ya se ha analizado
                if (posicion != -1)
                {
                    // Incrementamos el contador de apariciones
                    arrContadorLetras[posicion]++;
                }
                // Si el caracter no se ha analizado
                else
                {
                    // Añadimos el caracter a la lista de caracteres analizados
                    arrLetras[i] = frase[i];
                    // Inicializamos el contador de apariciones a 1
                    arrContadorLetras[i] = 1;
                }
            }

            // Buscamos el caracter con mayor número de apariciones
            for (int i = 0; i < arrContadorLetras.Length; i++)
            {
                if (arrContadorLetras[i] > contador)
                {
                    contador = arrContadorLetras[i];
                    posicion = i;
                }
            }

            // END YOUR OWN CODE

            if (contador > 1)
            {
                // Usamos posicion + 1 para obtener la posición real del carácter en la frase
                return "El valor '" + arrLetras[posicion] + "' se repite " + contador + " veces y la primera vez que aparece en la frase es en la posición " + (posicion + 1) + ".";
            }
            else
            {
                return "Todos los caracteres de la frase aparecen por igual.";
            }
        }



    }

}


