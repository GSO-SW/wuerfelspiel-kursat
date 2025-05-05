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
            wuerfel w1 = new wuerfel(seiten);

            //Assert
            Assert.AreEqual(6, w1.seiten);
        }
        [TestMethod]
        public void Wuerfel_artibuten_Test()
        {
            //Arange
            int seiten = 6;
            int augenanzahl = 1;

            //Act
            wuerfel w1 = new wuerfel(seiten);

            //Assert
            Assert.AreEqual(1, w1.augenanzahl);
            Assert.AreEqual(6, w1.seiten);

        }
    }
}
