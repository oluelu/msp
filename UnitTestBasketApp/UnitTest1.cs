using BasketApp;
using BasketApp.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestBasketApp
{
    [TestClass]
    public class UnitTest1
    {
        private IList<Product> products;

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

        [TestMethod]
        public void TestProduct_Is_Created()
        {
            // Arrange
            Product prod = new Product("Butter", 80);

            // Act
            string name = "Butter";
            double cost = 80;

            //Assert
            Assert.IsNotNull(prod);
            Assert.AreEqual(name, prod.Name);
            Assert.AreEqual(cost, prod.Cost);
        }

        [TestMethod]
        public void TestLine_Is_Created()
        {
            // Arrange
            Product prod = new Product("Butter", 80);
            LineItem line = new LineItem(prod, 34);

            // Act
            int unit = 34;

            //Assert
            Assert.IsNotNull(prod);
            Assert.AreEqual(unit, line.Unit);
        }


        [TestMethod]
        public void TestBasket_Is_Created()
        {
            // Arrange
            Product prod = new Product("Butter", 80);
            LineItem line = new LineItem(prod, 34);
            Basket basket = new Basket(new List<LineItem> { line });

            //Assert
            Assert.IsNotNull(basket);
        }

        [TestMethod]
        public void TestBasket_Has_Multiple_Items()
        {
            // Arrange
            Product prod = new Product("Butter", 80);
            LineItem line = new LineItem(prod, 34);
            LineItem line2 = new LineItem(prod, 4);
            Basket basket = new Basket(new List<LineItem> {
                line,
                line2,
            });

            //Act
            var itemCount = 2;

            //Assert//Assert
            Assert.IsNotNull(basket);
            Assert.AreEqual(itemCount, basket.ItemCount());
        }

        [TestMethod]
        public void TestButter_Deal_Applies()
        {
            // Arrange
            Product prod = new Product("Butter", 80);
            LineItem line = new LineItem(prod, 34);
            LineItem line2 = new LineItem(prod, 4);
            Basket basket = new Basket(new List<LineItem> {
                line,
                line2,
            });

            //Act
            var result = 0.00;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyButterDiscount());
        }

        [TestMethod]
        public void TestMilk_Deal()
        {
            // Arrange
            Product prod = new Product("Butter", 80);
            LineItem line = new LineItem(prod, 34);
            LineItem line2 = new LineItem(prod, 4);
            Basket basket = new Basket(new List<LineItem> {
                line,
                line2,
            });

            //Act
            var result = 0.00;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyMilkOffer());
        }
    }
}
