using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_erstellen()
        {
            //Arange
            int seiten = 6;

            //Act
            Wuerfel w = new Wuerfel(seiten);

            //Assert
            Assert.AreEqual(6, w.Seiten);
        }
        [TestMethod]
        public void Wuerfel_artibuten_Test()
        {
            //Arange
            int seiten = 6;
            int Augenanzahl = 1;

            //Act
            Wuerfel w1 = new Wuerfel(seiten);

            //Assert
            Assert.AreEqual(1, w1.Augenanzahl);
            Assert.AreEqual(6, w1.Seiten);

        }
    }
}
