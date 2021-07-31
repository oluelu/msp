using BasketApp;
using BasketApp.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            decimal testResult = 0.00M;

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
            decimal cost = 80;

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
            Basket basket = new Basket(new List<LineItem> { line,line2 });

            //Act
            var itemCount = 2;

            //Assert//Assert
            Assert.IsNotNull(basket);
            Assert.AreEqual(itemCount, basket.ItemCount());
        }

        [TestMethod] //review
        public void TestButter_Deal_Applies()
        {
            // Arrange
            Product prod = new Product(config.BUTTER, 0);
            LineItem line = new LineItem(prod, 0);
            LineItem line2 = new LineItem(prod, 0);
            Basket basket = new Basket(new List<LineItem> { line, line2});

            //Act
            var result = 0.00M;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyButterDiscount());
        }

        [TestMethod]
        public void TestButter_Deal_With_Item_Each()
        {
            // Arrange
            Product bread = new Product(config.BUTTER, config.PRICE_PER_UNIT_BUTTER);
            Product butter = new Product(config.BREAD, config.PRICE_PER_UNIT_BREAD);
            Product milk = new Product(config.MILK, config.PRICE_PER_UNIT_MILK);
            LineItem line1 = new LineItem(butter, 1);
            LineItem line2 = new LineItem(bread, 1);
            LineItem line3 = new LineItem(milk, 1);
            Basket basket = new Basket(new List<LineItem> { line1, line2, line3 });

            //Act
            var result = 3.10M;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyButterDiscount());
        }

        [TestMethod]
        public void TestButter_Deal_With__Muultiple_Items()
        {
            // Arrange
            Product butter = new Product(config.BUTTER, config.PRICE_PER_UNIT_BUTTER);
            Product bread = new Product(config.BREAD, config.PRICE_PER_UNIT_BREAD);
            Product milk = new Product(config.MILK, config.PRICE_PER_UNIT_MILK);
            LineItem line1 = new LineItem(butter, 2);
            LineItem line2 = new LineItem(bread, 1);
            LineItem line3 = new LineItem(milk, 8);
            Basket basket = new Basket(new List<LineItem> { line1, line2, line3 });

            //Act
            var result = 3.10M;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyButterDiscount());
        }
        [TestMethod]
        public void TestMilk_Deal()
        {
            // Arrange
            Product item = new Product(config.MILK, config.PRICE_PER_UNIT_MILK);
            LineItem line = new LineItem(item, 4); 
            Basket basket = new Basket(new List<LineItem> { line });

            //Act
            var result = 3.45M;

            //Assert//Assert 
            Assert.AreEqual(result, basket.ApplyMilkOffer());
        }
    }
}
