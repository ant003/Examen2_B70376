using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen2.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2.Pages
{
    public class IndexModel : PageModel
    {
        public bool viewFlag { set; get; }
        public double totalPrice { set; get; }
        public String feedback { set; get; }
        pizzaController pizzaC = new pizzaController();

        public List<String> ingredients { set; get; }

        public String[,] table { set; get; }

        public String size { set; get; }

        public double sizePrice { set; get; }


        //public String[][] table { set; get; }

        //public List<double> prices { set; get; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            ingredients = new List<String>();
            //prices = new List<double>();
          
            

            ingredients.Add(Request.Form["Jamón"]);
            ingredients.Add(Request.Form["Hongos"]);
            ingredients.Add(Request.Form["Cebolla"]);
            ingredients.Add(Request.Form["Carne molida"]);
            ingredients.Add(Request.Form["Chile"]);
            ingredients.Add(Request.Form["Jalapeño"]);
            ingredients.Add(Request.Form["Tomate"]);
            ingredients.Add(Request.Form["Piña"]);
            ingredients.Add(Request.Form["Peperoni"]);

            size = Request.Form["Tamaño"];
            ingredients.RemoveAll(item => item == null);

            if (ingredients.Count == 0)
                feedback = "Por favor seleccione al menos un ingrediente";
            if (size == null)
                feedback = "Por favor seleccione un tamaño";
            
            if(ingredients.Count != 0 && size != null)
            {
                totalPrice = pizzaC.calculatePrice(ingredients, size);
                viewFlag = true;
            }

            table = new String[ingredients.Count(),2];

            sizePrice = pizzaC.GetPrice(size);

            int x = 0;
            int y = 0;
            foreach(String ingredient in ingredients)
            {
                table[x,y] = ingredient;
                y++;
                table[x,y] = "₡" + pizzaC.GetPrice(ingredient).ToString();
                x++;
                y = 0;
            }
            
        }
    }
}
