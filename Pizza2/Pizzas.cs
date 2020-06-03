using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pizza2
{
    public static class Pizzas
    {
        public static ObservableCollection<Pizza> PizzasList { get; set; } = new ObservableCollection<Pizza>()
        {
            // Margherita
            new Pizza(0, 0, 0, new ObservableCollection<Ingredient>(){Ingredients.IngredientsList[21]}),

            // Carbonara
            new Pizza(0, 0, 0, new ObservableCollection<Ingredient>(){Ingredients.IngredientsList[23], Ingredients.IngredientsList[22], Ingredients.IngredientsList[2]}),

            // test
            new Pizza(1, 1, 1, new ObservableCollection<Ingredient>(){Ingredients.IngredientsList[23], Ingredients.IngredientsList[22], Ingredients.IngredientsList[2]})

        };
    }
}
