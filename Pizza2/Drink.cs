using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

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
        public double DrinkPrizeAdjusted { get; set; }

        // this is stupid
        public void UpdatePrice()
        {
            if (DrinkSize == 0)
            {
                DrinkPrizeAdjusted = DrinkPrize * 0.75;
            }
            if (DrinkSize == 1)
            {
                DrinkPrizeAdjusted = DrinkPrize;
            }
            if (DrinkSize == 2)
            {
                DrinkPrizeAdjusted = DrinkPrize * 1.25;
            }
        }

        // can't get binding to work without duplicate list
        public ObservableCollection<Drink> DrinksListCopy { get; set; } = Drinks.DrinksList;
    }
}
