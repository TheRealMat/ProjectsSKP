using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    public static class Drinks
    {
        public static ObservableCollection<Drink> DrinksList { get; set; } = new ObservableCollection<Drink>()
        {
            new Drink("Boda", 3),
            new Drink("Bepis", 4),
            new Drink("Diet Bepis", 5),
            new Drink("Dr. Gibb", 3)
        };
    }
}
