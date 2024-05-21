namespace cSharp
{
    public class VT10_00_Pilas
    {
        public static void Print()
        {
            string Opcion = "";
            string[] Pila = new string[10];

            string Cadena = "";

            // Se inicializa la pila para poder trabajar con ella
            InicializarPila(Pila);

            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("MENÚ DE OPERACIONES CON UNA PILA DE DATOS");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("1. Añadir elemento a la pila");
                Console.WriteLine("2. Sacar elemento de la pila");
                Console.WriteLine("3. Longitud de la pila");
                Console.WriteLine("4. Mostrar pila");
                Console.WriteLine("5. Salir");

                Console.WriteLine("");

                Console.Write("Opción seleccionada: ");

                Opcion = Console.ReadLine();

                switch (Opcion)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("");
                            Console.Write("Cadena: ");

                            Cadena = Console.ReadLine();
                        } while (Cadena == "");

                        AddPila(Cadena, Pila);

                        Console.WriteLine("");

                        break;

                    case "2":
                        Console.WriteLine("Cadena: " + SacarDeLaPila(Pila));

                        Console.WriteLine("");

                        break;

                    case "3":
                        Console.WriteLine("La pila contiene: " + LongitudPila(Pila) + " cadenas");

                        Console.WriteLine("");

                        break;

                    case "4":
                        EscribirPila(Pila);

                        Console.WriteLine("");

                        break;

                    default:
                        break;
                }

            } while (Opcion!= "5");
        }

        public static void InicializarPila(string[] Pila) 
        { 
            for (int i = 0; i < Pila.Length; i++)
            {
                Pila[i] = "*";
            }
        }

        public static int LongitudPila(string[] Pila)
        {
            int contador = 0;

            for (int i = 0; i < Pila.Length; i++)
            {
                if (Pila[i] == "*") // Si la pila tiene "*" asumimos que es una posición libre
                {
                    break;
                }
                else
                {
                    contador++;     // De lo contrario, está informada esa posición de la pila
                }
            }

            return contador;
        }

        public static bool EstaVaciaPila(string[] Pila)
        {
            return Pila[0] == "*";
        }

        public static bool EstaLlenaPila(string[] Pila)
        {
            return Pila[Pila.Length - 1] != "*";
        }
        public static void AddPila(string cadena, string[] Pila)
        {
            if (EstaLlenaPila(Pila))    // Si está llena --> Error
            {
                Console.WriteLine("La pila está llena. Operación denegada.");
            }
            else
            {
                Pila[LongitudPila(Pila)] = cadena; // Se obtiene el número de elementos de la pila, y se inserta en la posición siguiente
            }
        }
        public static string SacarDeLaPila(string[] Pila)
        {
            string resultado = "";

            if (EstaVaciaPila(Pila))    // Si está vacía --> Error
            {
                Console.WriteLine("La pila está vacía. Operación denegada.");
                return "";
            }
            else
            {
                resultado = Pila[LongitudPila(Pila) - 1]; // Se obtiene la cadena a sacar de la pila
                Pila[LongitudPila(Pila) - 1] = "*";       // Se libera la última posición de la pila que esté informada
                
                return resultado;                         // Se retorna la cadena
            }
        }
        public static void EscribirPila(string[] Pila)
        {
            for (int i = 0; i < Pila.Length; i++)
            {
                if(Pila[i] == "*")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Posición " + i + ": " + Pila[i]);
                }
            }
        }
    }
}
