using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.tests
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var bil = new Bil();

            //Act
            var pris = bil.Pris();

            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        
        public void Køretøj()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string køretøj = "Bil";

            //Assert
            Assert.AreSame(køretøj, bil.Køretøj());

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nummerpladen du har indtastet indeholder for mange cifre")]

        public void ForLangNummerPlade()
        {
            //Arrange
            var bil = new Bil("cb123456", new DateTime(2018, 9, 14));
        }

        [TestMethod]

        public void NummerPlade()
        {
            //Arrange
            var bil = new Bil("cd12345", new DateTime(2018, 9, 14));

            //Act
            string nummerPlade = bil.NummerPlade;

            //Assert
            Assert.AreEqual(7, nummerPlade.Length);
        }
    }
}
