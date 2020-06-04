using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizza2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cart cart = new Cart { };
        Pizza pizza;
        public double TotalPrize { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            EditPizzaMenu.Visibility = Visibility.Collapsed;
            pizlist.DataContext = cart.PizzasInCart;
            drinkslist.DataContext = cart.DrinksInCart;
            PresetPizzaList.DataContext = Pizzas.PizzasList;


            BreadDropdown.DataContext = Ingredients.BreadTypesList;
            CheeseDropdown.DataContext = Ingredients.CheeseTypesList;
            SauceDropdown.DataContext = Ingredients.SauceTypesList;

            UpdateTotalPrice();

        }

        private void RemovePizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            cart.PizzasInCart.Remove((Pizza)btnsrs.DataContext);
            UpdateTotalPrice();
        }
        private void RemoveDrink(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            cart.DrinksInCart.Remove((Drink)btnsrs.DataContext);
            UpdateTotalPrice();
        }

        private void EditPizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            thepiz.DataContext = ((Pizza)btnsrs.DataContext);
            pizza = ((Pizza)btnsrs.DataContext);

            BreadDropdown.SelectedIndex = pizza.Bread;
            CheeseDropdown.SelectedIndex = pizza.Cheese;
            SauceDropdown.SelectedIndex = pizza.Sauce;
            LargeCheck.IsChecked = pizza.IsLarge;
            PizzaPrize.DataContext = pizza;

            IngredientsList.DataContext = pizza.PizzaIngredients;

            PizzaSelect.Visibility = Visibility.Collapsed;
            EditPizzaMenu.Visibility = Visibility.Visible;
        }

        private void NewPizza(object sender, RoutedEventArgs e)
        {
            cart.PizzasInCart.Add(new Pizza(0, 0, 0, new ObservableCollection<Ingredient>(){}));
            UpdateTotalPrice();
        }
        private void NewDrink(object sender, RoutedEventArgs e)
        {
            cart.DrinksInCart.Add(new Drink(Drinks.DrinksList[0].Name, Drinks.DrinksList[0].DrinkPrize));
            UpdateTotalPrice();
        }
        private void AcceptPizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            thepiz.DataContext = ((Pizza)btnsrs.DataContext);

            pizza.SetBread(BreadDropdown.SelectedIndex);
            pizza.SetCheese(CheeseDropdown.SelectedIndex);
            pizza.SetSauce(SauceDropdown.SelectedIndex);
            pizza.IsLarge = LargeCheck.IsChecked.Value;
            UpdateTotalPrice();

            PizzaSelect.Visibility = Visibility.Visible;
            EditPizzaMenu.Visibility = Visibility.Collapsed;
        }

        private void UpdateTotalPrice()
        {
            TotalPrize = 0;
            bool isDiscount = false;
            foreach (Pizza pizza in cart.PizzasInCart)
            {
                TotalPrize += pizza.PizzaPrize;
            }
            foreach (Drink drink in cart.DrinksInCart)
            {
                TotalPrize += drink.DrinkPrizeAdjusted;
            }
            if (cart.PizzasInCart.Count >= 2 && cart.DrinksInCart.Count >= 2)
            {
                isDiscount = true;
            }
            if (isDiscount)
            {
                TotalPrize -= GetDiscount();
            }
            CartTotalPrice.Text = "Current total: " + TotalPrize.ToString() + " PizzaBucks™";
            if (isDiscount)
            {
                CartTotalPrice.Text += $" ({GetDiscount().ToString()} PizzaBucks™ discount)";
            }
        }


        private double GetDiscount()
        {
            double maxPrice = 0;
            foreach(Pizza pizza in cart.PizzasInCart)
            {
                if (Ingredients.BreadTypesList[pizza.Bread].Price > maxPrice)
                {
                    maxPrice = Ingredients.BreadTypesList[pizza.Bread].Price;
                }
            }
            return maxPrice;
        }

        private void SauceDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pizza.SetSauce(SauceDropdown.SelectedIndex);
        }

        private void CheeseDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pizza.SetCheese(CheeseDropdown.SelectedIndex);
        }

        private void BreadDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pizza.SetBread(BreadDropdown.SelectedIndex);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // string compare. sue me
            var btnsrs = (RadioButton)sender;
            byte buttonNum = 0;
            if (btnsrs.Name == "sizeSmall")
            {
                buttonNum = 0;
            }
            else if (btnsrs.Name == "sizeMedium")
            {
                buttonNum = 1;
            }
            else if (btnsrs.Name == "sizeLarge")
            {
                buttonNum = 2;
            }
            ((Drink)btnsrs.DataContext).DrinkSize = buttonNum;
            UpdateTotalPrice();
        }




        // weird ghost behavior if i combine these events
        private void LargeCheck_Checked(object sender, RoutedEventArgs e)
        {
            pizza.IsLarge = true;
        }
        private void LargeCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            pizza.IsLarge = false;
        }

        private void ComboBoxDrinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var btnsrs = (ComboBox)sender;
            ((Drink)btnsrs.DataContext).DrinkPrize = Drinks.DrinksList[btnsrs.SelectedIndex].DrinkPrize;
            ((Drink)btnsrs.DataContext).Name = Drinks.DrinksList[btnsrs.SelectedIndex].Name;
            UpdateTotalPrice();
        }

        private void PresetPizzaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pizza.Sauce = Pizzas.PizzasList[PresetPizzaList.SelectedIndex].Sauce;
            pizza.Cheese = Pizzas.PizzasList[PresetPizzaList.SelectedIndex].Cheese;
            pizza.Bread = Pizzas.PizzasList[PresetPizzaList.SelectedIndex].Bread;

            pizza.PizzaPrize = Pizzas.PizzasList[PresetPizzaList.SelectedIndex].PizzaPrize;

            // why doesn't this work?
            pizza.PizzaIngredients.Clear();
            foreach (Ingredient ingredient in Pizzas.PizzasList[PresetPizzaList.SelectedIndex].PizzaIngredients)
            {
                pizza.PizzaIngredients.Add(ingredient);
            }



            SauceDropdown.SelectedIndex = pizza.Sauce;
            BreadDropdown.SelectedIndex = pizza.Bread;
            CheeseDropdown.SelectedIndex = pizza.Cheese;

            


        }

        private void NewTopping(object sender, RoutedEventArgs e)
        {
            pizza.PizzaIngredients.Add(new Ingredient(Ingredients.IngredientsList[0].Name, Ingredients.IngredientsList[0].Price));
        }
        private void RemoveTopping(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            pizza.PizzaIngredients.Remove((Ingredient)btnsrs.DataContext);
        }

        private void ComboBoxIngredients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // the dropdown box
            var btnsrs = (ComboBox)sender;
            // the specific ingredient
            var theIngredient = ((Ingredient)btnsrs.DataContext);

            int ingredientIndex = pizza.PizzaIngredients.IndexOf(theIngredient);

            //pizza.PizzaIngredients[ingredientIndex].Name = ((Ingredient)btnsrs.DataContext).Name;
            //pizza.PizzaIngredients[ingredientIndex].Price = ((Ingredient)btnsrs.DataContext).Price;

            pizza.PizzaIngredients[ingredientIndex] = ((Ingredient)btnsrs.DataContext);
        }




        //private void NewPizza(object sender, RoutedEventArgs e)
        //{
        //    var btnsrs = (Button)sender;
        //    something.datacontext = ((Pizza)btnsrs.DataContext);
        //}
    }
}

