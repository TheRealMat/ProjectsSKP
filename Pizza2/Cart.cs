using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Cart
    {

        public ObservableCollection<Pizza> PizzasInCart { get; set; } = new ObservableCollection<Pizza>()
        {
            new Pizza("flat fucking bread")
        };
        public ObservableCollection<Drink> DrinksInCart { get; set; } = new ObservableCollection<Drink>()
        {

        };
    }
}
