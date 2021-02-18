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
        [TestMethod]
        public static void Impossibile()
        {
            double a = 8;
            double b = 10;
            bool valore_aspettato = true;
            bool resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public static void EqDiSecondoGrado()
        {
            double a = 0;
            bool valore_aspettato = false;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public static void CalcoloDelta()
        {
            double a = 5;
            double b = 2;
            double c = 1;
            double valore_aspettato = -16;
            double resp = Equazioni.IsDegree2(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
        public static void CalcoloDelta2()
        {
            double a = 4;
            double b = -4;
            double c = 1;
            double valore_aspettato = 0;
            double resp = Equazioni.IsDegree2(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public static void CalcolaEquazione2Grado()
        {
            double a = 1;
            double b = -7;
            double c = 10;
            double valore_aspettato1 = 2;
            double valore_aspettato2 = 5;
            string resp = Equazioni.CalcoloEquazione(a, b, c);
            Assert.AreEqual(valore_aspettato1, valore_aspettato2, resp);
        }
        [TestMethod]
        public static void Equazione1Grado()
        {
            double a = 2;
            double b = -6;
            double valore_aspettato = 3;
            string resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}

