using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.IO;
using static System.Collections.Specialized.BitVector32;

namespace DietApp.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Foodstuff_Init_InitializesCorrectly()
        {
            // ARRANGE
            double expectedPrice = 10.5;
            int expectedCaloricity = 100;
            Foodstuff foodstuff = new Foodstuff();

            // ACT
            foodstuff.Init(expectedPrice, expectedCaloricity);

            // ASSERT
            ClassicAssert.AreEqual(expectedPrice, foodstuff.Price);
            ClassicAssert.AreEqual(expectedCaloricity, foodstuff.Caloricity);
        }

        [Test]
        public void Foodstuff_ProductValue_ReturnsCorrectValue()
        {
            // ARRANGE
            double price = 10.0;
            int caloricity = 200;
            Foodstuff foodstuff = new Foodstuff(price, caloricity);

            // ACT
            double productValue = foodstuff.ProductValue();

            // ASSERT
            ClassicAssert.AreEqual(price / caloricity, productValue);
        }

        [Test]
        public void Foodstuff_Read_ReadsCorrectly()
        {
            // ARRANGE
            double expectedPrice = 15.5;
            int expectedCaloricity = 150;
            string input = $"{expectedPrice}\n{expectedCaloricity}\n";
            Foodstuff foodstuff = new Foodstuff();
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // ACT
            foodstuff.Read();

            // ASSERT
            ClassicAssert.AreEqual(expectedPrice, foodstuff.Price);
            ClassicAssert.AreEqual(expectedCaloricity, foodstuff.Caloricity);
        }

        [Test]
        public void Dieta_ProductValue_ReturnsCorrectValue()
        {
            // ARRANGE
            double price = 20.0;
            int caloricity = 300;
            int breadUnits = 2;
            Dieta dieta = new Dieta(price, caloricity, breadUnits);

            // ACT
            double productValue = dieta.ProductValue();

            // ASSERT
            ClassicAssert.AreEqual(price / (caloricity + (breadUnits * 2)), productValue);
        }

        [Test]
        public void Diet_TotalValue_ReturnsCorrectValue()
        {
            // ARRANGE
            double foodstuffPrice = 10.0;
            int foodstuffCaloricity = 200;
            double dietaPrice = 20.0;
            int dietaCaloricity = 300;
            int breadUnits = 2;
            Foodstuff foodstuff = new Foodstuff(foodstuffPrice, foodstuffCaloricity);
            Dieta dieta = new Dieta(dietaPrice, dietaCaloricity, breadUnits);
            Diet diet = new Diet(foodstuff, dieta);

            // ACT
            double totalValue = diet.TotalValue();

            // ASSERT
            ClassicAssert.AreEqual(foodstuffPrice / foodstuffCaloricity + dietaPrice / (dietaCaloricity + (breadUnits * 2)), totalValue);
        }

        [Test]
        public void Diet_Value()
        {
            // ARRANGE
            double foodstuffPrice = 10.0;
            int foodstuffCaloricity = 200;
            double dietaPrice = 20.0;
            int dietaCaloricity = 300;
            int breadUnits = 2;
            Foodstuff foodstuff = new Foodstuff(foodstuffPrice, foodstuffCaloricity);
            Dieta dieta = new Dieta(dietaPrice, dietaCaloricity, breadUnits);
            Diet diet = new Diet(foodstuff, dieta);

            // ACT
            double totalValue = diet.TotalValue();

            // ASSERT
            ClassicAssert.AreEqual(foodstuffPrice / foodstuffCaloricity + dietaPrice / (dietaCaloricity + (breadUnits * 2)), totalValue);
        }

        [Test]
        public void Dieta_ProductValue_Value228()
        {
            // ARRANGE
            double price = 20.0;
            int caloricity = 300;
            int breadUnits = 2;
            Dieta dieta = new Dieta(price, caloricity, breadUnits);

            // ACT
            double productValue = dieta.ProductValue();

            // ASSERT
            ClassicAssert.AreEqual(price / (caloricity + (breadUnits * 2)), productValue);
        }

        [Test]
        public void Foodstuff_Read_Auff()
        {
            // ARRANGE
            double expectedPrice = 15.5;
            int expectedCaloricity = 150;
            string input = $"{expectedPrice}\n{expectedCaloricity}\n";
            Foodstuff foodstuff = new Foodstuff();
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // ACT
            foodstuff.Read();

            // ASSERT
            ClassicAssert.AreEqual(expectedPrice, foodstuff.Price);
            ClassicAssert.AreEqual(expectedCaloricity, foodstuff.Caloricity);
        }

        [Test]
        public void Foodstuff_ProductValue_HihihiSl()
        {
            // ARRANGE
            double price = 10.0;
            int caloricity = 200;
            Foodstuff foodstuff = new Foodstuff(price, caloricity);

            // ACT
            double productValue = foodstuff.ProductValue();

            // ASSERT
            ClassicAssert.AreEqual(price / caloricity, productValue);
        }

        [Test]
        public void Foodstuff_Init()
        {
            // ARRANGE
            double expectedPrice = 10.5;
            int expectedCaloricity = 100;
            Foodstuff foodstuff = new Foodstuff();

            // ACT
            foodstuff.Init(expectedPrice, expectedCaloricity);

            // ASSERT
            ClassicAssert.AreEqual(expectedPrice, foodstuff.Price);
            ClassicAssert.AreEqual(expectedCaloricity, foodstuff.Caloricity);
        }

    }
}

