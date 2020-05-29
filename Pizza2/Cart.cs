using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Cart
    {

        public ObservableCollection<Pizza> PizzasInCart = new ObservableCollection<Pizza>()
        {
            new Pizza("flat fucking bread")
        };
    }
}
