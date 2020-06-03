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
            new Ingredient("pepperoni", 0),
            new Ingredient("mozzarella", 0),
            new Ingredient("bacon", 0),
            new Ingredient("garlic", 0),
            new Ingredient("sausage", 0),
            new Ingredient("onion", 0),
            new Ingredient("mushroom", 0),
            new Ingredient("tomato", 0),
            new Ingredient("parmigiano-reggiano", 0),
            new Ingredient("red pepper", 0),
            new Ingredient("ham", 0),
            new Ingredient("chicken", 0),
            new Ingredient("olives", 0),
            new Ingredient("green pepper", 0),
            new Ingredient("pineapple", 0),
            new Ingredient("salami", 0),
            new Ingredient("jalapeño", 0),
            new Ingredient("proscuitto", 0),
            new Ingredient("beep", 0),
            new Ingredient("anchovies", 0),
            new Ingredient("capers", 0),
            new Ingredient("oregano", 0),
            new Ingredient("eggs", 0),
            new Ingredient("parmesan", 0)
        };

        public static ObservableCollection<Ingredient> BreadTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("neapolitan", 0),
            new Ingredient("chicago", 0),
            new Ingredient("greek", 0),
            new Ingredient("siliciann", 0)
        };

        public static ObservableCollection<Ingredient> CheeseTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("mozzarella", 0),
            new Ingredient("provolene", 0),
            new Ingredient("cheddar", 0),
            new Ingredient("parmesan", 0),
            new Ingredient("no cheese", 0)
        };

        public static ObservableCollection<Ingredient> SauceTypesList { get; set; } = new ObservableCollection<Ingredient>()
        {
            new Ingredient("tomato sauce", 0),
            new Ingredient("no sauce", 0)
        };
    }
}
