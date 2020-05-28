using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza2
{
    class Ingredient
    {
        public string name;
        public double price;

        public Ingredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
