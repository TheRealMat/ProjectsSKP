using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pizzaria
{
    class CreatedPizzas : INotifyPropertyChanged
    {
        Pizza selectedPizza = new Pizza("Margherita", IngredientTypes.doughs[0], new List<Ingredient>() { IngredientTypes.toppings[1] }, new List<Ingredient>() { }, new List<Ingredient>() { IngredientTypes.sauces[0] }, new List<Ingredient> { IngredientTypes.spices[0] });
        public Pizza SelectedPizza { get { OnPropertyChanged(); return selectedPizza; } set { selectedPizza = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public ObservableCollection<Pizza> pizzas { get; } = new ObservableCollection<Pizza>();

        public void CreatePizza(string pizzaName, Ingredient dough, List<Ingredient> toppings, List<Ingredient> cheeses, List<Ingredient> sauces, List<Ingredient> spices)
        {
            pizzas.Add(new Pizza(pizzaName, dough, toppings, cheeses, sauces, spices));
        }
    }

}
