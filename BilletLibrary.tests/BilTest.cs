using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.tests
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void Price()
        {
            //Arrange
            var bil = new Bil();

            //Act
            var pris = bil.Pris();

            //Assert
            Assert.AreEqual(240,pris);

        }
    }
}
