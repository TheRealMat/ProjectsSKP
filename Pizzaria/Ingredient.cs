using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class Ingredient
    {
        private string ingredientName;
        public String IngredientName { get { return ingredientName; } set { ingredientName = value; } }


        public Ingredient(string SauceName)
        {
            this.IngredientName = SauceName;

        }

    }
}
