using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    static class IngredientTypes
    {
        public static List<Ingredient> sauces { get; } = new List<Ingredient>() { 
            new Ingredient("tomato sauce", 0)

        };

        public static List<Ingredient> toppings { get; } = new List<Ingredient>() {
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
            new Ingredient("capers", 0)

        };

        public static List<Ingredient> cheeses { get; } = new List<Ingredient>() {
            new Ingredient("mozzarella", 0),
            new Ingredient("provolene", 0),
            new Ingredient("cheddar", 0),
            new Ingredient("parmesan", 0)

        };

        public static List<Ingredient> doughs { get; } = new List<Ingredient>() {
            new Ingredient("neapolitan", 0),
            new Ingredient("chicago", 0),
            new Ingredient("greek", 0),
            new Ingredient("siliciann", 0)

        };

        public static List<Ingredient> spices { get; } = new List<Ingredient>() {
            new Ingredient("oregano", 0),

        };

        public static Ingredient GetIngredient(List<Ingredient> list, int num)
        {
            return list[num];
        }



    }
}
