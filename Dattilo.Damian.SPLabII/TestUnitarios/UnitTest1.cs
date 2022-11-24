using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarUtilALaCartuchera()
        {
            Cartuchera<Util> cartuchera1 = new Cartuchera<Util>(2);
            Cartuchera<Util> cartuchera2 = new Cartuchera<Util>(2);
            Lapiz lapiz = new Lapiz("Faber Castell", 42, eColor.Rojo, eTrazo.B);
            cartuchera1 += lapiz;
            Assert.AreNotEqual(cartuchera1, cartuchera2);
        }
    }
}
