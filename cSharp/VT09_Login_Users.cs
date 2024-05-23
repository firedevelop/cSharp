using System;
namespace cSharp
{
    public class VT09_Login_Users
    {
        /* Escribe una funci�n llamada �Login�, que recibe un nombre de usuario y una contrase�a y te devuelve Verdadero si el nombre de usuario es �usuario1� y la contrase�a es �123456�. Adem�s recibe el n�mero de intentos que se ha intentado hacer login y si no se ha podido hacer login incremente este valor. Adem�s, escribe un programa principal donde se pida un nombre de usuario y una contrase�a y se intente hacer login, solamente tenemos tres oportunidades para intentarlo. */
        public static void Print()
        {
            string username;
            int pass;
            int counter = 1;
            bool result = false;
            int loginAttempts = 3;
            do
            {
                Console.WriteLine("Login Attempts " + loginAttempts + " of:" + counter);
                Console.WriteLine("username: ");
                username = Console.ReadLine();
                Console.WriteLine("pass: ");
                pass = int.Parse(Console.ReadLine());
                result = LoginCheck(username, pass);
                Console.WriteLine(result ? "Hi " + username : "Login failed!");
                counter++;

            } while (counter <= loginAttempts && !result);




        }
        public static bool LoginCheck(string username, int pass)
        {
            return (username == "john" && pass == 123);
        }
    }
}
