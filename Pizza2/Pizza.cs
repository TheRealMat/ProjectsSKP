using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Pizza
    {
        public string Name { get; set; }
        public int Bread { get; set; }
        public int Cheese { get; set; }
        public int Sauce { get; set; }
        public bool IsLarge { get; set; }
        public double PizzaPrize { get; set; }
        // list of toppings
        // total price

        ObservableCollection<Ingredient> PizzaIngredients = new ObservableCollection<Ingredient>();


        public Pizza(string name)
        {
            this.Name = name;
        }
        public void UpdatePrice()
        {
        }

        public void SetBread(int amount)
        {
            Bread = amount;
        }
        public void SetCheese(int amount)
        {
            Cheese = amount;
        }
        public void SetSauce(int amount)
        {
            Sauce = amount;
        }
    }
}
