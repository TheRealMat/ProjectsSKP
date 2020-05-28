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
            new Ingredient ("asbestos", 500000),
            new Ingredient ("space cancer", 420.69),
            new Ingredient ("anthrax", 42),
            new Ingredient ("pineapple", 5554454114)
        };

    }
}
