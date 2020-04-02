using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pizzaria
{
    class CreatedPizzas
    {
        public ObservableCollection<Pizza> pizzas { get; } = new ObservableCollection<Pizza>();

        public void CreatePizza(string pizzaName, Ingredient dough, List<Ingredient> toppings, List<Ingredient> cheeses, List<Ingredient> sauces, List<Ingredient> spices)
        {
            pizzas.Add(new Pizza(pizzaName, dough, toppings, cheeses, sauces, spices));
        }
    }

}
