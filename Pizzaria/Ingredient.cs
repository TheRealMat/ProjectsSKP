using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class Ingredient
    {
        private string ingredientName;
        public String IngredientName { get { return ingredientName; } set { ingredientName = value; } }

        // decimal is used for money
        private decimal ingredientPrice;
        public decimal IngredientPrice { get { return ingredientPrice; } set { ingredientPrice = value; } }


        public Ingredient(string SauceName, decimal IngredientPrice)
        {
            this.IngredientName = SauceName;
            this.IngredientPrice = IngredientPrice;
        }

    }
}
