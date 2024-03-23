namespace cSharp
{
    public class c019_enum_foreach_arraybool
    {
        public static void Print()
        {
        enum poblaciones { Aldea = 1000, Municipio = 10000, Ciudad = 100000 };
        static void Main()
        {
            //------------------------------------------------ Tipo Enum
            int ciudadanos = 1200;

            if (ciudadanos <= (int)poblaciones.Aldea)
            {
                Console.WriteLine("Es una aldea");
            }
            else if (ciudadanos <= (int)poblaciones.Municipio)
            {
                Console.WriteLine("Es un municipio");
            }
            else
            {
                Console.WriteLine("Es una ciudad");
            }

            //------------------------------------------------ Arrays

            //--- Declaración e inicialización
            char[] arrayChar = { 'a', 'e', 'i', 'o', 'u' };

            bool[] arrayBool;
            arrayBool = new bool[5]; // bool[] arrayBool = new bool[5];

            int[] arrayEnteros = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //--- Modificación de valores
            arrayEnteros[3] = 44;
            // arrayEnteros[10] = 44; ------------------ genera un error en ejecución por desbordamiento

            //--- Inicialización con bucle For
            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                arrayEnteros[i] = i;
            }

            //--- Visualización con bucle foreach
            foreach (int num in arrayEnteros)
            {
                Console.WriteLine(num);
            }

            //------------------------------------------------ Strings
            string frase = "Hola onliners";

            //--- Visualización con bucle foreach
            foreach (char c in frase)
            {
                Console.WriteLine("La letra que estamos tratando es la: " + c);
                Console.WriteLine("La letra que estamos tratando es la: {0}", c);
            }

            //------------------------------------------------ Break y Continue
            for (int i = 0; i < 10; i++) // Ejemplo comportamiento break
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++) // Ejemplo comportamiento continue
            {
                if (i < 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}