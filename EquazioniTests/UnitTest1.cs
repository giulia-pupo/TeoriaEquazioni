using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void Determinata()
        {
            double a = 5;
            bool valore_aspettato = true;
            bool resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(valore_aspettato, resp);
        }
     
    }
}
