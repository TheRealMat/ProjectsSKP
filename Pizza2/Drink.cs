using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pizza2
{
    public class Drink : INotifyPropertyChanged
    {
        public string Name { get; set; }

        private byte drinkSize;
        public byte DrinkSize { get { return drinkSize; } set { drinkSize = value; UpdatePrice(); OnPropertyChanged(); } }

        private double drinkPrize;
        public double DrinkPrize { get { return drinkPrize; } set { drinkPrize = value; UpdatePrice(); OnPropertyChanged(); } }

        private double drinkPrizeAdjusted;
        public double DrinkPrizeAdjusted { get { return drinkPrizeAdjusted; } set { drinkPrizeAdjusted = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public Drink(string name, double drinkPrize)
        {
            this.Name = name;
            this.DrinkPrize = drinkPrize;
            UpdatePrice();
        }

        // this is stupid
        public void UpdatePrice()
        {
            if (DrinkSize == 0)
            {
                DrinkPrizeAdjusted = DrinkPrize * 0.75;
            }
            else if (DrinkSize == 1)
            {
                DrinkPrizeAdjusted = DrinkPrize;
            }
            else if (DrinkSize == 2)
            {
                DrinkPrizeAdjusted = DrinkPrize * 1.25;
            }
        }

        // can't get binding to work without duplicate list
        public ObservableCollection<Drink> DrinksListCopy { get; set; } = Drinks.DrinksList;
    }
}
