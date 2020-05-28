using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Pizza
    {
        public string Name { get; set; }
        // type of bread
        // type of cheese
        // list of toppings
        // pizza size
        // total price

        ObservableCollection<Ingredient> PizzaIngredients = new ObservableCollection<Ingredient>();

        public Pizza(string name)
        {
            this.Name = name;
        }

    }
}
