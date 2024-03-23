namespace cSharp
{
    public class c018_break_loop
    {
        public static void Print()
        {
            string frase = "Hola Mundo";
            bool contieneHola = frase.Contains("Mundo");
            Console.WriteLine(contieneHola);  // true

            int posicion = frase.IndexOf("Mundo");
            Console.WriteLine(posicion);  // 5 (posición de la primera letra de "Mundo")

            string textoConEspacios = "    Hola     ";
            string textoSinEspacios = textoConEspacios.Trim();
            Console.WriteLine(textoSinEspacios);  // "Hola"

            string[] palabras = frase.Split(' ');
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            // Resultado:
            // Hola
            // Mundo

            string nuevaFrase = frase.Remove(1);  // Elimina desde la posición 1 hasta el final
            Console.WriteLine(nuevaFrase);  // "Mundo"

            // Ejemplo de ToUpper() y ToLower()
            Console.WriteLine(frase.ToUpper());  // "HOLA MUNDO"
            Console.WriteLine(frase.ToLower());  // "hola mundo"


        }
    }
}


