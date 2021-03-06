using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Determinata()
        {
            double a = 5;
            //bool valore_aspettato = true;
            bool resp = Equazioni.IsDetermined(a);
            //Assert.AreEqual(valore_aspettato, resp);
            Assert.IsTrue(resp);
        }
        [TestMethod]
        public void Impossibile()
        {
            double a = 8;
            double b = 10;
            //bool valore_aspettato = false;
            bool resp = Equazioni.IsInconsisted(a, b);
            //Assert.AreEqual(valore_aspettato, resp);
            Assert.IsFalse(resp);
        }
        [TestMethod]
        public  void EqDiSecondoGrado()
        {
            double a = 0;
            bool valore_aspettato = false;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public  void CalcoloDelta()
        {
            double a = 5;
            double b = 2;
            double c = 1;
            double valore_aspettato = -16;
            double resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void CalcoloDelta2()
        {
            double a = 4;
            double b = -4;
            double c = 1;
            double valore_aspettato = 0;
            double resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void CalcolaEquazione2Grado()
        {
            double a = 1;
            double b = -7;
            double c = 10;
            string valore_aspettato = $"I risultati dell'equazione sono {5} e {2}";
            string resp = Equazioni.CalcoloEquazione(a, b, c);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void Equazione1Grado()
        {
            double a = 2;
            double b = -6;
            string valore_aspettato = $"Il risultato dell'equazione � {3}";
            string resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}

