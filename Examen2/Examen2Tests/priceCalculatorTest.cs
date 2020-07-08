using Examen.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Examen2Tests
{
    [TestClass]
    public class priceCalculatorTest
    {
        priceCalculator calculator = new priceCalculator();

        [TestMethod]
        public void CaculatePartialPriceGivenPizzaWithTomateJamonHongosGet590()
        {
            List<String> ingredients = new List<String>();
            ingredients.Add("Tomate");
            ingredients.Add("Jamón");
            ingredients.Add("Hongos");

            pizzaModel pizza = new pizzaModel(ingredients, "Individual");

            double actual = calculator.CaculatePartialPrice(pizza);

            Assert.AreEqual(1590, actual);

        }

        [TestMethod]
        public void CalculatePriceWithTaxGiven6000And13Get6780()
        {
            double actual = calculator.CalculatePriceWithTax(1590, 13);
            Assert.AreEqual(1796.7, actual);
        }

        [TestMethod]
        public void CalculateTotalPricePizzaWithCebollaJamonHongosIndividualGet1632()
        {
            List<String> ingredients = new List<String>();
            ingredients.Add("Cebolla");
            ingredients.Add("Jamón");
            ingredients.Add("Hongos");

            pizzaModel pizza = new pizzaModel(ingredients, "Individual");

            double actual = calculator.CalculateTotalPrice(pizza, 13);
            Assert.AreEqual(1632.85, actual);
        }

        [TestMethod]
        public void GetIngredientesGivenCebollaJamonHongosGetCebollaJamonHongos()
        {
            List<String> ingredients = new List<String>();
            ingredients.Add("Cebolla");
            ingredients.Add("Jamón");
            ingredients.Add("Hongos");

            pizzaModel pizza = new pizzaModel(ingredients, "Individual");
            List<String> actual = pizza.Ingredients;

            CollectionAssert.AreEqual(ingredients, actual);
        }

        [TestMethod]
        public void GetSizeGivenSizeGrandeGetSizeGrande()
        {
            pizzaModel pizza = new pizzaModel();
            pizza.Size = "Grande";

            String actual = pizza.Size;

            Assert.AreEqual("Grande", actual);
        }


    }
}
