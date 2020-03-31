using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    static class PizzaTypes
    {
        public static List<Pizza> pizzas { get; } = new List<Pizza>() {
            new Pizza("Margherita", 7, IngredientTypes.doughs[0], new List<Ingredient>() {IngredientTypes.toppings[1] }, new List<Ingredient>() { }, new List<Ingredient>() { IngredientTypes.sauces[0]}, new List<Ingredient> {IngredientTypes.spices[0]})

        };


    }

}
