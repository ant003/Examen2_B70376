using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class priceCalculator
    {
        private int[] prices { set; get; }

        public priceCalculator(int[] prices)
        {
            this.prices = prices;
        }

        public double CaculatePartialPrice()
        {
            double partialTotalPrice = 0;

            foreach(int price in prices)
            {
                partialTotalPrice += price;
            }

            return partialTotalPrice;
        }

        public double CalculatePriceWithTax(double totalPrice, double taxRate)
        {
            return totalPrice + totalPrice * (taxRate / 100);
        }

    }
}
