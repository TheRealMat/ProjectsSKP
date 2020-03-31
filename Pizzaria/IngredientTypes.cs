using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    static class IngredientTypes
    {
        public static List<Ingredient> sauces { get; } = new List<Ingredient>() { 
            new Ingredient("tomato sauce")

        };

        public static List<Ingredient> toppings { get; } = new List<Ingredient>() {
            new Ingredient("pepperoni"),
            new Ingredient("mozzarella"),
            new Ingredient("bacon"),
            new Ingredient("garlic"),
            new Ingredient("sausage"),
            new Ingredient("onion"),
            new Ingredient("mushroom"),
            new Ingredient("tomato"),
            new Ingredient("parmigiano-reggiano"),
            new Ingredient("red pepper"),
            new Ingredient("ham"),
            new Ingredient("chicken"),
            new Ingredient("olives"),
            new Ingredient("green pepper"),
            new Ingredient("pineapple"),
            new Ingredient("salami"),
            new Ingredient("jalapeño"),
            new Ingredient("proscuitto"),
            new Ingredient("beep"),
            new Ingredient("anchovies"),
            new Ingredient("capers")

        };

        public static List<Ingredient> cheeses { get; } = new List<Ingredient>() {
            new Ingredient("mozzarella"),
            new Ingredient("provolene"),
            new Ingredient("cheddar"),
            new Ingredient("parmesan")

        };

        public static List<Ingredient> doughs { get; } = new List<Ingredient>() {
            new Ingredient("neapolitan"),
            new Ingredient("chicago"),
            new Ingredient("greek"),
            new Ingredient("siliciann")

        };

        public static List<Ingredient> spices { get; } = new List<Ingredient>() {
            new Ingredient("oregano"),

        };

        public static Ingredient GetIngredient(List<Ingredient> list, int num)
        {
            return list[num];
        }



    }
}
