using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class priceCalculator
    {
        public priceCalculator()
        {

        }

        public double CaculatePartialPrice(double[] prices)
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
