using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class Pizza
    {
        private string pizzaName;
        public String PizzaName { get { return pizzaName; } set { pizzaName = value; } }


        private double pizzaPrice;
        public double PizzaPrice { get { return pizzaPrice; } set { pizzaPrice = value; } }


        private List<string> ingredients = new List<string>();
        public List<string> Ingredients { get { return ingredients; } set { ingredients = value; } }




        public Pizza(string PizzaName, double PizzaPrice, List<string> Ingredients)
        {
            this.PizzaName = PizzaName;
            this.PizzaPrice = PizzaPrice;
            this.Ingredients = Ingredients;
        }

    }
}
