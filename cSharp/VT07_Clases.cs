using System;
namespace cSharp
{
    public class VT07_Clases
    {

        public static void Print()
        {
            //------------------------------------------------------------ Clases
            Coche auto = new Coche();

            auto.marca = "Seat";
            //auto.modelo = "Ibiza";
            auto.cambiarModelo("Ibiza");
        }
    }

    public class Coche
    {
        public string marca = "";
        private string modelo = "";
        int marcha = 0;
        bool arrancado = false;

        public void arrancar()
        {
            arrancado = true;
            marcha = 1;
        }
		
        public void apagar()
        {
            arrancado = false;
            marcha = 0;
        }

        public int dameMarcha()
        {
            return marcha;
        }
		
        public void cambiarModelo(string modelo)
        {
            this.modelo = modelo;
        }
    }
}