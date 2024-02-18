using System;
namespace Csharp
{
	public class _04_TryParse
	{
		public _04_TryParse()
		{
            int numValido = Int32.Parse("-100");
            Console.WriteLine(numValido);
            // La salida por pantalla será -100
            while (Int32.TryParse("50", out int miNumero))
                // El argumento miNumero, se pasa por referencia. Lo veremos más adelante en el apartado 4.5. Llamadas a funciones. Tipos y funcionamento.
                Console.WriteLine(miNumero);
            // La salida por pantalla será 50
        }
    }
}

