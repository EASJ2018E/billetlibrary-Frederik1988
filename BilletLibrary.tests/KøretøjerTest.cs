using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.tests
{
    [TestClass]
    public class KøretøjerTest
    {
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var bil = new Bil();

            //Act
            var pris = bil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
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
        
    }
}
