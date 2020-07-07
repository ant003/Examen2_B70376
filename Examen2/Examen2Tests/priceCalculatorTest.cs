using Examen.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen2Tests
{
    [TestClass]
    public class priceCalculatorTest
    {
        priceCalculator calculator = new priceCalculator();

        [TestMethod]
        public void CaculatePartialPriceGiven5Times5Get25()
        {
            double[] prices = new double[5];

            for(int i = 0; i < 5; ++i)
            {
                prices[i] = 5;
            }

            double actual = calculator.CaculatePartialPrice(prices);

            Assert.AreEqual(25, actual);

        }

        [TestMethod]
        public void CalculatePriceWithTaxGiven6000And13Get6780()
        {
            double actual = calculator.CalculatePriceWithTax(6000, 13);
            Assert.AreEqual(6780, actual);
        }
    }
}
