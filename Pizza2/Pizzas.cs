using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pizza2
{
    public static class Pizzas
    {
        public static ObservableCollection<Pizza> PizzasList { get; set; } = new ObservableCollection<Pizza>()
        {
            new Pizza(0, 0, 0)
        };
    }
}
