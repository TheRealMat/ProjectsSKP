using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class Pizza
    {
        private string pizzaName;
        public String PizzaName { get { return pizzaName; } set { pizzaName = value; } }


        private double price;
        public double Price { get { return price; } set { price = value; } }

        private string pizzaPrice;
        public string PizzaPrice { get { return pizzaPrice; } set { pizzaPrice = value; } }



        private string pizzaIngredients;
        public String PizzaIngredients { get { return pizzaIngredients; } set { pizzaIngredients = value; } }


        private List<string> ingredients = new List<string>();
        public List<string> Ingredients { get { return ingredients; } set { ingredients = value; } }




        public Pizza(string PizzaName, double Price, List<string> Ingredients)
        {
            this.PizzaName = PizzaName;
            this.Price = Price;
            this.Ingredients = Ingredients;

            // textblocks can't display databinding and also a symbol
            this.PizzaPrice = Price + "€";

            // list has to be displayed as a string in the databinding
            this.pizzaIngredients = combineString(Ingredients);

        }
        
        private string combineString(List<string> list)
        {
            string converted = "";
            foreach(string str in list)
            {
                converted += str;
                converted += ", ";
            }



            return converted;
        }


    }
}
