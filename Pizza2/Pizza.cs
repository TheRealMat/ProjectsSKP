using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Pizza
    {
        public string Name { get; set; }
        public int Bread { get; set; }
        int Cheese { get; set; }

        // list of toppings
        // pizza size
        // total price

        ObservableCollection<Ingredient> PizzaIngredients = new ObservableCollection<Ingredient>();


        public Pizza(string name)
        {
            this.Name = name;
        }

        public void SetBread(int amount)
        {
            Bread = amount;
        }

    }
}
