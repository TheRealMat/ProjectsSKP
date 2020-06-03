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
            new Ingredient("pepperoni", 3),
            new Ingredient("mozzarella", 5),
            new Ingredient("bacon", 2),
            new Ingredient("garlic", 3),
            new Ingredient("sausage", 5),
            new Ingredient("onion", 3),
            new Ingredient("mushroom", 4),
            new Ingredient("tomato", 1),
            new Ingredient("parmigiano-reggiano", 2),
            new Ingredient("red pepper", 3),
            new Ingredient("ham", 4),
            new Ingredient("chicken", 5),
            new Ingredient("olives", 3),
            new Ingredient("green pepper", 4),
            new Ingredient("pineapple", 2),
            new Ingredient("salami", 3),
            new Ingredient("jalapeño", 4),
            new Ingredient("proscuitto", 2),
            new Ingredient("beep", 3),
            new Ingredient("anchovies", 4),
            new Ingredient("capers", 2),
            new Ingredient("oregano", 1),
            new Ingredient("eggs", 3),
            new Ingredient("parmesan", 2)
        };

        public static ObservableCollection<Ingredient> BreadTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("neapolitan", 4),
            new Ingredient("chicago", 5),
            new Ingredient("greek", 6),
            new Ingredient("siliciann", 4)
        };

        public static ObservableCollection<Ingredient> CheeseTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("mozzarella", 4),
            new Ingredient("provolene", 4),
            new Ingredient("cheddar", 6),
            new Ingredient("parmesan", 5),
            new Ingredient("no cheese", 0)
        };

        public static ObservableCollection<Ingredient> SauceTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("tomato sauce", 1),
            new Ingredient("no sauce", 0)
        };
    }
}
