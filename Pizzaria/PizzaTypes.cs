using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria
{
    class PizzaTypes
    {
        private List<Pizza> pizzas = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
    }

}
