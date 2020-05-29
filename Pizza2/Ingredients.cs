using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    public static class Ingredients
    {
        // list of available ingredients
        public static ObservableCollection<Ingredient> IngredientsList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient ("asbestos", 1),
            new Ingredient ("space cancer", 420.69),
            new Ingredient ("anthrax", 42),
            new Ingredient ("pineapple", 14),
            new Ingredient ("rat meat", 9.99)
        };

        public static ObservableCollection<Ingredient> BreadTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("flat bread", 100),
            new Ingredient("pancake", 200),
            new Ingredient("piece of toast", 5),
            new Ingredient("cardboard", 3)
        };

        public static ObservableCollection<Ingredient> CheeseTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("stinky", 5),
            new Ingredient("the moon", 50000000000000000.99),
            new Ingredient("moldy",4),
            new Ingredient("no cheese :(",0)
        };

        public static ObservableCollection<Ingredient> SauceTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("liquid gibs",4),
            new Ingredient("toxic waste",2)
        };
    }
}
