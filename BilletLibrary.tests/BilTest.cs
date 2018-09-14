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
        
        public void K�ret�j()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string k�ret�j = "Bil";

            //Assert
            Assert.AreSame(k�ret�j, bil.K�ret�j());

        }
    }
}
