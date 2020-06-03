using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pizza2
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Ingredient(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        // can't get binding to work without duplicate list
        public ObservableCollection<Ingredient> IngredientsListCopy { get; set; } = Ingredients.IngredientsList;
    }
}
