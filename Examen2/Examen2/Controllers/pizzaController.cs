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
        public double calculatePrice(List<String> ingredients, String size)
        {
            pizzaModel pizza = new pizzaModel(ingredients, size);
            priceCalculator priceC = new priceCalculator();

            return priceC.CalculateTotalPrice(pizza, 13);
        }

    }
}