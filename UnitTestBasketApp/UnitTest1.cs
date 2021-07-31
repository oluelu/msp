using BasketApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestBasketApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBasket_Balance_Is_Returned()
        {
            // Arrange
            Services basketService = new Services(null);

            // Act
            double testResult = 0.00;

            //Assert
            Assert.AreEqual(testResult, basketService.GetBasketTotal());
        }
    }
}
