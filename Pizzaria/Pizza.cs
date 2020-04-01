using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class Pizza
    {
        private string pizzaName;
        public String PizzaName { get { return pizzaName; } set { pizzaName = value; } }





        private string pizzaIngredients;
        public String PizzaIngredients { get { return pizzaIngredients; } set { pizzaIngredients = value; } }


        private Ingredient dough;
        public Ingredient Dough { get { return dough; } set { dough = value; } }

        private List<Ingredient> toppings = new List<Ingredient>();
        public List<Ingredient> Toppings { get { return toppings; } set { toppings = value; } }

        private List<Ingredient> cheeses = new List<Ingredient>();
        public List<Ingredient> Cheeses { get { return cheeses; } set { cheeses = value; } }

        private List<Ingredient> sauces = new List<Ingredient>();
        public List<Ingredient> Sauces { get { return sauces; } set { sauces = value; } }

        private List<Ingredient> spices = new List<Ingredient>();
        public List<Ingredient> Spices { get { return spices; } set { spices = value; } }











        public Pizza(string PizzaName, Ingredient Dough, List<Ingredient> Toppings, List<Ingredient> Cheeses, List<Ingredient> Sauces, List<Ingredient> Spices)
        {
            this.PizzaName = PizzaName;

            this.Dough = Dough;
            this.Toppings = Toppings;
            this.Cheeses = Cheeses;
            this.Sauces = Sauces;
            this.Spices = Spices;






            // need new description system
            // list has to be displayed as a string in the databinding
            //this.pizzaIngredients = combineString(Ingredients);

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
