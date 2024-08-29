using BhaskaraApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BhaskaraTest
{
    [TestClass()]


    public class BhaskaraAppTests
    {


        [TestMethod]
        [DataRow(1, -5, 6, 3, 2)]      // Raízes esperadas: 3 e 2
        [DataRow(1, 1, -12, 3, -4)]    // Raízes esperadas: 3 e -4
        [DataRow(1, -7, 12, 4, 3)]     // Raízes esperadas: 4 e 3
        [DataRow(2, -11, 5, 5, 0.5)]   // Raízes esperadas: 5 e 0.5
        [DataRow(1, -9, 20, 5, 4)]     // Raízes esperadas: 5 e 4
        public void Teste_de_Raizes(double a, double b, double c, double NumEsperado1, double NumEsperado2)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var (raiz1, raiz2) = bhaskara.CalcularRaizes();

            // Assert
            Assert.AreEqual(NumEsperado1, raiz1, "A raiz 1 está Errado.");
            Assert.AreEqual(NumEsperado2, raiz2, "A raiz 2 está Errado.");
        }

        [TestMethod]
        [DataRow(2, 4, 2, 0)]      // Delta esperado: 0
        [DataRow(1, -2, 1, 0)]     // Delta esperado: 0
        [DataRow(3, 6, -9, 144)]   // Delta esperado: 144
        [DataRow(5, 0, -25, 500)]  // Delta esperado: 500
        [DataRow(1, -1, -12, 49)]  // Delta esperado: 49


        public void Teste_de_Delta(double a, double b, double c, double DeltaEsp)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var Delt = bhaskara.CalcularDelta();

            // Assert
            Assert.AreEqual(DeltaEsp, Delt, "O valor de Delta está incorreto.");

        }


        [TestMethod]
        [DataRow(1, -6, 9, 0, 0, 0)]
        [DataRow(0, 0, 0, 0, 0, 0)]
        public void Teste_de_Uma_Raiz(double a, double b, double c, double Delta, double NumEsperado1, double NumEsperado2)
        {

            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var deltaCalcu = bhaskara.TemRaizesReais();

            // Assert
            Assert.AreEqual(Delta, NumEsperado1);
        }
    }
}
    