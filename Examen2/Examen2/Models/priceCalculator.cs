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

        public double CalculateTotalPrice(pizzaModel pizza, double taxRate)
        {
            return CalculatePriceWithTax(CaculatePartialPrice(pizza), taxRate);
        }

        public double CaculatePartialPrice(pizzaModel pizza)
        {
            double partialTotalPrice = 0;

            double value = 0;

            foreach(String ingredient in pizza.Ingredients)
            {
                pizza.Prices.TryGetValue(ingredient, out value);
                partialTotalPrice += value;
            }

            pizza.Prices.TryGetValue(pizza.Size, out value);
            partialTotalPrice += value;
            return partialTotalPrice;
        }

        public double CalculatePriceWithTax(double totalPrice, double taxRate)
        {
            return totalPrice + totalPrice * (taxRate / 100);
        }

    }
}
