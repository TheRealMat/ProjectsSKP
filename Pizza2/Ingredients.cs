using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza2
{
    public static class Ingredients
    {
        // list of available ingredients
        static List<Ingredient> ingredients = new List<Ingredient>()
        {
            new Ingredient ("asbestos", 1),
            new Ingredient ("space cancer", 420.69),
            new Ingredient ("anthrax", 42),
            new Ingredient ("pineapple", 14),
            new Ingredient ("rat meat", 9.99)
        };

        static Dictionary<string, double> breadTypes = new Dictionary<string, double>()
        {
            {"flat bread", 100},
            {"pancake", 200},
            {"piece of toast", 5},
            {"cardboard", 3}
        };

        static Dictionary<string, double> cheeseTypes = new Dictionary<string, double>()
        {
            {"stinky", 5},
            {"the moon", 50000000000000000.99},
            {"moldy", 4},
            {"no cheese :(", 0}
        };
    }
}
