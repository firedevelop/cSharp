using System;
namespace cSharp
{
    public class VT06_Order_Number
    {
        public static void Print()
        {
            //------------------------------------------------------------- Se establece la secuencia de números
            int[] secuenciaNumeros = { 5, 9, 16, 7, 2, 6, 20, 4, 32, 19 };

            //--- 1º se crea un array de la misma longitud que la secuencia de números

            int[] secuenciaOrdenada = new int[secuenciaNumeros.Length];

            //--- 2º se ordena sobre el array creado el contenido del array secuenciaNumeros
            int numAnterior = 0;
            int numActual = 0;

            for (int i = 0; i < secuenciaOrdenada.Length; i++)
            {
                numActual = 0;

                for (int j = 0; j < secuenciaNumeros.Length; j++)
                {
                    if (numAnterior < secuenciaNumeros[j])
                    {
                        if (secuenciaNumeros[j] < numActual || numActual == 0)
                        {
                            numActual = secuenciaNumeros[j];
                        }
                    }
                }

                secuenciaOrdenada[i] = numActual;
                numAnterior = numActual;
            }

            //--- 3º se visualiza en consola el contenido del array con los números ordenados
            for (int i = 0; i < secuenciaOrdenada.Length; i++)
            {
                Console.WriteLine(secuenciaOrdenada[i]);
            }
            //------------------------------------------------------------- Fin programa
        }
    }
}