using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza2
{
    public class Drink
    {
        public Drink(string name, double drinkPrize)
        {
            this.Name = name;
            this.DrinkPrize = drinkPrize;
        }
        public string Name { get; set; }

        public byte DrinkSize { get; set; }

        public double DrinkPrize { get; set; }

        // this is stupid
        public void UpdatePrice()
        {
            if (DrinkSize == 0)
            {
                DrinkPrize *= 0.75;
            }
            if (DrinkSize == 1)
            {

            }
            if (DrinkSize == 2)
            {
                DrinkPrize *= 1.25;
            }
        }
    }
}
