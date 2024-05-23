namespace cSharp
{
    public class VT10_07_Examen
    {
        public static void Print()
        {
            String cadena;
            char letra = 'a';
            int contador = 0;
            Console.WriteLine("Introduce una cadena: ");
            cadena = Console.ReadLine();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == letra)
                {
                    contador++;
                }
            }
            Console.WriteLine("La cadena tiene {0} caracteres y {1} letras a", cadena.Length, contador);
            Console.WriteLine("Introduce una letra: ");
            letra = Char.Parse(Console.ReadLine());
            contador = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == letra)
                {
                    contador++;
                }
            }
            Console.WriteLine("La cadena tiene {0} letras {1}", contador, letra);
            Console.ReadKey();
        }
    }
}

/* output:

    Introduce una cadena:
    hola amigo
    La cadena tiene 10 caracteres y 2 letras a

    Introduce una letra:
    o

    La cadena tiene 2 letras o

*/

