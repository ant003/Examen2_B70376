using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen2.Controllers
{
    public class pizzaController : Controller
    {
        pizzaModel pModel;

        public double calculatePrice(List<String> ingredients, String size)
        {
            pizzaModel pizza = new pizzaModel(ingredients, size);
            priceCalculator priceC = new priceCalculator();
            this.pModel = pizza;

            return priceC.CalculateTotalPrice(pizza, 13);
        }

        public double GetPrice(String item)
        {
            double value = 0;

            pModel.Prices.TryGetValue(item, out value);

            return value;
        }

    }
}