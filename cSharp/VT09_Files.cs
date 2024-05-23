using System;
namespace cSharp
{
    internal class VT09_Files
    {
        public static void Print()
        {
            //-- Resolución ejercicio 1
            string usuario = "";
            string contrasena = "";
            int intentos = 0;

            do
            {
                Console.Write("Introduce usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Introduce contraseña: ");
                contrasena = Console.ReadLine();

            } while (!Login(usuario, contrasena, ref intentos) && intentos < 3);

            if (intentos < 3) 
            {
                Console.WriteLine("Usuario correcto!!!");
            }
            else
            {
                Console.WriteLine("Usuario incorrecto!!!");
            }

            //--- Resolución ejercicio 2
            //-- Sin recursividad

            int numero1 = 5;
            int resultado = 1;


            for(int i = numero1; i > 0; i--) 
            {
                resultado = resultado * i;
            }
                       
            Console.WriteLine("El factorial de " + numero1 + " es " + resultado);

            //------------- Con recursividad
            resultado = 0;
            resultado = factorial_recursivo(numero1);       // 5*(4*(3*(2*(1))))

            Console.WriteLine("El factorial de " + numero1 + " es " + resultado);


            //------------------------------------------------------------------ Librerías

        }
        public static bool Login(string user, string password, ref int contador)
        {
            if (user == "usuario1" && password == "asdasd")
            {
                return true;
            }
            else
            {
                contador++;
                return false;
            }
        }

        public static int factorial_recursivo(int numero)
        {
            if (numero <= 1)
            {
                return 1;
            }
            else
            {
                return numero * factorial_recursivo(numero - 1);
            }
        }
    }
}