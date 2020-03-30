using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class PizzaTypes
    {
        public List<Pizza> pizzas { get; } = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
    }

}
