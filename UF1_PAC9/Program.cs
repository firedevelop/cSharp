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


            //------------------------------------------------------------------------------------------ Ejecución libre del programa

            //-------------------------- Se valida que la frase introducida sea correcta
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
            //	INICIO - SOLUCION ALUMNO
            if (frase.Length >= 20 && frase.Length <= 55)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Inténtelo de nuevo. La frase introducida debe estar comprendida entre 20 y 55 caracteres");
                return false;
            }
            // FIN - SOLUCION ALUMNO
        }

        public static string ContarCaracteres(string frase)
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            //	INICIO - SOLUCION ALUMNO
            foreach (char c in frase)
            {
                if (char.IsUpper(c))
                {
                    mayusculas++;
                }
                else if (char.IsDigit(c))
                {
                    numeros++;
                }
                // minusculas y el resto de caracteres
                else
                {
                    minusculas++;
                }
            }
            // FIN - SOLUCION ALUMNO

            return "La frase contiene " + mayusculas + " letras mayúsculas, " + minusculas + " letras minúsculas y " + numeros + " números.";
        }

        public static string InvertirFrase(string frase)
        {
            //	INICIO - SOLUCION ALUMNO

            /* solucion usando Reverse:
            char[] fraseToChar = frase.ToCharArray();
            Array.Reverse(fraseToChar);
            string resultado = new string(fraseToChar);
            return resultado;
            */

            char[] fraseToChar = frase.ToCharArray();

            // Inicialización
            char[] fraseInvertida = new char[fraseToChar.Length];

            // "fraseToChar.Length -1" significa la última posición del array. Al ponernos al final e ir restando 1 en cada iteración es lo mismo, que ir recorriendolo en sentido inverso.
            for (int i = 0; i < fraseToChar.Length; i++)
            {
                fraseInvertida[i] = fraseToChar[fraseToChar.Length - 1 - i];
            }

            // Inicialización y devolver 
            string resultado = new string(fraseInvertida);
            return resultado;
            // FIN - SOLUCION ALUMNO
        }

        public static string CaracterMasRepetido(string frase)
        {
            char[] arrLetras = new char[frase.Length];
            int[] arrContadorLetras = new int[frase.Length];
            int posicion;
            int contador;

            // INICIO - SOLUCION ALUMNO
            // Inicialización de variables
            posicion = 0;
            contador = 0;

            // llamar a funcion para obtener frase invertida
            frase = InvertirFrase(frase);

            // recorremos los caracteres de frase
            for (int i = 0; i < frase.Length; i++)
            {
                // buscamos con IndexOf(array_donde_buscamos, elemento_a_encontrar)
                posicion = Array.IndexOf(arrLetras, frase[i]);

                // Array.IndexOf devuelve -1 si el elemento no es encontrado
                // Elemento encontrado:
                if (posicion != -1)
                {
                    // [posicion] es el numero de indice que nos da IndexOf al encontrar el elemento. Aqui se añadira 1 si esta vacio o bien se incrementara en caso de ya existir.
                    arrContadorLetras[posicion]++;
                }
                // Elemento NO encontrado. Lo añadimos al array y marcamos que ha aparecido 1 vez.
                else
                {
                    // añadir el nuevo caracter
                    arrLetras[i] = frase[i];
                    // poner que lo ha encontrado 1 vez para que si lo vuelve a encontrar se pueda ir incrementando
                    arrContadorLetras[i] = 1;
                }
            }


            for (int i = 0; i < arrContadorLetras.Length; i++)
            {
                // encontramos el indice con el numero mas alto. Puesto que hemos declarado contador=0 y en el array siempre se guardan minimo el numero 1 usamos esta condicion.
                if (arrContadorLetras[i] > contador)
                {
                    // Al ir declarando el numero encontrado a contador terminaremos por encontrar el indice con el numero mayor comparándolo con él mismo en cada iteración.
                    contador = arrContadorLetras[i];
                    // indice donde encontramos el numero mayor.
                    // NO deberíamos sumarle 1. Pero debido a que el return del final de esta función figura como "[posicion - 1]" y tenemos prohibido modificarlo debemos falsear el resultado. Lo correcto sería poner "posicion = i;" y en el return arrLetras[posicion]
                    posicion = i + 1;
                }
            }

            // FIN - SOLUCION ALUMNO

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