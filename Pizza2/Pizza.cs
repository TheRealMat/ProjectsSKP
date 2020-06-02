using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pizza2
{
    public class Pizza : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string Name { get; set; }


        private int bread;
        public int Bread { get { return bread; } set { bread = value; Update(); OnPropertyChanged(); } }

        private int cheese;
        public int Cheese { get { return cheese; } set { cheese = value; Update(); OnPropertyChanged(); } }

        private int sauce;
        public int Sauce { get { return sauce; } set { sauce = value; Update(); OnPropertyChanged(); } }

        private bool isLarge;
        public bool IsLarge { get { return isLarge; } set { isLarge = value; Update(); OnPropertyChanged(); } }
        private double pizzaPrize;
        public double PizzaPrize { get { return pizzaPrize; } set { pizzaPrize = value; OnPropertyChanged(); } }
        // list of toppings
        // total price

        ObservableCollection<Ingredient> PizzaIngredients = new ObservableCollection<Ingredient>();



        public Pizza(int bread, int cheese, int sauce, ObservableCollection<Ingredient> pizzaIngredients)
        {
            this.Bread = bread;
            this.Cheese = cheese;
            this.Sauce = sauce;
            this.PizzaIngredients = pizzaIngredients;
            Update();
        }
        public void UpdatePrice()
        {
            PizzaPrize = Ingredients.BreadTypesList[Bread].Price + Ingredients.CheeseTypesList[Cheese].Price + Ingredients.SauceTypesList[Sauce].Price;
            if (IsLarge)
            {
                PizzaPrize *= 1.25;
            }
        }
        public void Update()
        {
            UpdatePrice();
            UpdateName();
        }
        public void UpdateName()
        {
            Name = "";
            if (isLarge)
            {
                Name += "Large ";
            }
            Name += $"{Ingredients.BreadTypesList[bread].Name} pizza with {Ingredients.CheeseTypesList[cheese].Name}, {Ingredients.SauceTypesList[sauce].Name}";
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
