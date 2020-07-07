using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class pizzaModel
    {
        private List<String> ingredients;
        private String size;
        private IDictionary<String, double> prices { set; get; }
       

        public pizzaModel(List<String> ingredients, String size)
        {
            this.ingredients = ingredients;
            this.size = size;
            this.InitiatePrices();
        }

        private void InitiatePrices()
        {
            this.prices = new Dictionary<String, double>();
            this.prices.Add("Jamón", 250);
            this.prices.Add("Hongos", 120);
            this.prices.Add("Cebolla", 75);
            this.prices.Add("Carne molida", 200);
            this.prices.Add("Chile", 110);
            this.prices.Add("Jalapeño", 300);
            this.prices.Add("Tomate", 220);
            this.prices.Add("Piña", 170);
            this.prices.Add("Peperoni", 310);
            this.prices.Add("Individual", 1000);
            this.prices.Add("Pequeña", 3000);
            this.prices.Add("Mediana", 3500);
            this.prices.Add("Grande", 5000);
            this.prices.Add("Extra grande", 6500);
        }

        public List<String> Ingredients
        {
            get { return ingredients; }   
            set { ingredients = value; }
        }

        public String Size
        {
            get { return size; }
            set { size = value; }
        }

        public IDictionary<String, double> Prices
        {
            get { return prices; }
            set { prices = value; }
        }
    }
}
