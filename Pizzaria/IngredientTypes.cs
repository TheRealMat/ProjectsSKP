using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class IngredientTypes
    {
        public List<Ingredient> sauces { get; } = new List<Ingredient>() { 
            new Ingredient("tomato sauce")

        };

        public List<Ingredient> toppings { get; } = new List<Ingredient>() {
            new Ingredient("pepperoni"),
            new Ingredient("mozzarella"),
            new Ingredient("bacon"),
            new Ingredient("garlic"),
            new Ingredient("sausage"),
            new Ingredient("onion"),
            new Ingredient("mushroom"),
            new Ingredient("oregano"),
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

        public List<Ingredient> cheeses { get; } = new List<Ingredient>() {
            new Ingredient("mozzarella"),
            new Ingredient("provolene"),
            new Ingredient("cheddar"),
            new Ingredient("parmesan"),

        };

        public List<Ingredient> doughs { get; } = new List<Ingredient>() {
            new Ingredient("neapolitan"),
            new Ingredient("chicago"),
            new Ingredient("greek"),
            new Ingredient("siliciann")

        };

        public List<Ingredient> spices { get; } = new List<Ingredient>() {
            new Ingredient("i guess something goes here"),

        };



        public Ingredient GetIngredient(List<Ingredient> list, int num)
        {
            return list[num];
        }




    }
}
