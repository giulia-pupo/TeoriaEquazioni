using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
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
        public static void Impossibile()
        {
            double a = 8;
            double b = 10;
            bool valore_aspettato = true;
            bool resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, resp);
        }
        public static void EqDiSecondoGrado()
        {
            double a = 0;
            bool valore_aspettato = false;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(valore_aspettato, resp);
        }
        public static void CalcoloDelta()
        {
            double a = 5;
            double b = 2;
            double c = 1;
            double valore_aspettato = -16;
            double resp = Equazioni.IsDegree2(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}

