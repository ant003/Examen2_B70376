using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2.Pages
{
    public class IndexModel : PageModel
    {

        public double totalPrice { set; get; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            List<String> ingredients = new List<String>();
       
            ingredients.Add(Request.Form["Jamón"]);
            ingredients.Add(Request.Form["Hongos"]);
            ingredients.Add(Request.Form["Cebolla"]);
            ingredients.Add(Request.Form["Carne molida"]);
            ingredients.Add(Request.Form["Chile"]);
            ingredients.Add(Request.Form["Jalapeño"]);
            ingredients.Add(Request.Form["Tomate"]);
            ingredients.Add(Request.Form["Piña"]);
            ingredients.Add(Request.Form["Peperoni"]);

        }
    }
}
