using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.tests
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var mc = new MC();

            //Act
            var pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]

        public void Køretøj()
        {
            //Arrange
            var mc = new MC();

            //Act
            string køretøj = "MC";

            //Assert
            Assert.AreSame(køretøj, mc.Køretøj());

        }
    }
}
