using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Pizza2
{
    class Pizza
    {
        public string Name { get; set; }


        private int bread;
        public int Bread { get { return bread; } set { bread = value; UpdatePrice(); } }

        private int cheese;
        public int Cheese { get { return cheese; } set { cheese = value; UpdatePrice(); } }

        private int sauce;
        public int Sauce { get { return sauce; } set { sauce = value; UpdatePrice(); } }

        private bool isLarge;
        public bool IsLarge { get { return isLarge; } set { isLarge = value; UpdatePrice(); } }
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
            PizzaPrize = Ingredients.BreadTypesList[Bread].Price + Ingredients.CheeseTypesList[Cheese].Price + Ingredients.SauceTypesList[Sauce].Price;
            if (IsLarge)
            {
                PizzaPrize *= 1.25;
            }
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
