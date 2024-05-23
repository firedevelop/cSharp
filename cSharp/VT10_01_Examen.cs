/*
 using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAC_Desarrollo_Entrega_2S2324;

namespace PAC_Desarrollo_TEST_2S2324
{
    //------------------------------------------------- Conjunto de test que calcula si el número está dentro de rango
    [TestClass]
    public class Punto1
    {
        //------------------------------------------------- test límite inferior
        [TestMethod]
        public void TestValorInferior()
        {
            bool resultado = Program.FraseValida("Holaa caracolacola.");

            Assert.AreEqual(false, resultado);
        }

        //------------------------------------------------- test límite superior
        [TestMethod]
        public void TestValorSuperior()
        {
            bool resultado = Program.FraseValida("Hola k ase esto es una frase demasiado larga para que pase la validación.");

            Assert.AreEqual(false, resultado);
        }

        //------------------------------------------------- test caso correcto
        [TestMethod]
        public void FraseValida()
        {
            bool resultado = Program.FraseValida("Esto es una frase que cumple con las condiciones.");

            Assert.AreEqual(true, resultado);
        }
    }

    //------------------------------------------------- Conjunto de test que obtiene el recuento de mayúsculas, números y resto
    [TestClass]
    public class Punto2
    {
        //------------------------------------------------- test caso correcto
        [TestMethod]
        public void Punto01()
        {
            string patron = "La frase contiene 6 letras mayúsculas, 51 letras minúsculas y 3 números.";
            string muestra = "Est0 e$ 1 pru3Ba d cómo el contador DeberÍa fun-cionar BieN.";
            string resultado = Program.ContarCaracteres(muestra);

            Assert.AreEqual(patron, resultado);
        }
    }

    //------------------------------------------------- Conjunto de test que obtiene la frase invertida
    [TestClass]
    public class Punto3
    {
        //------------------------------------------------- test caso correcto
        [TestMethod]
        public void Punto01()

        {
            string patron = ".senoicidnoc sal noc elpmuc euq esarf anu se otsE";
            string muestra = "Esto es una frase que cumple con las condiciones.";
            string resultado = Program.InvertirFrase(muestra);

            Assert.AreEqual(patron, resultado);
        }
    }

    //------------------------------------------------- Conjunto de test que obtiene qué número se repite más veces y en qué posición del array
    [TestClass]
    public class Punto4
    {
        //------------------------------------------------- test caso todos iguales
        [TestMethod]
        public void FraseNoRepe()
        {
            string patron = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string muestra = "Todos los caracteres de la frase aparecen por igual.";
            string resultado = Program.CaracterMasRepetido(patron);

            Assert.AreEqual(muestra, resultado);
        }

        //------------------------------------------------- test caso correcto (string de la plantilla)
        [TestMethod]
        public void FraseSiRepe1()
        {
            string patron = "Esto es una frase que cumple con las condiciones.";
            string muestra = "El valor ' ' se repite 8 veces y la primera vez que aparece en la frase es en la posición 5.";
            string resultado = Program.CaracterMasRepetido(patron);

            Assert.AreEqual(muestra, resultado);
        }

        //------------------------------------------------- test caso correcto (string del enunciado)
        [TestMethod]
        public void FraseSiRepe2()
        {
            string patron = "Esto es una frase que cumple con las condiciones.";
            string muestra = "El valor ' ' se repite 8 veces y aparece en el array de recuento en la posición 5.";
            string resultado = Program.CaracterMasRepetido(patron);

            Assert.AreEqual(muestra, resultado);
        }
    }
}

*/