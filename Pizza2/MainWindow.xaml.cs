using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            EditPizzaMenu.Visibility = Visibility.Collapsed;
            pizlist.DataContext = cart.PizzasInCart;
            drinkslist.DataContext = cart.DrinksInCart;

            BreadDropdown.DataContext = Ingredients.BreadTypesList;
            CheeseDropdown.DataContext = Ingredients.CheeseTypesList;
            SauceDropdown.DataContext = Ingredients.SauceTypesList;


        }

        private void RemovePizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            cart.PizzasInCart.Remove((Pizza)btnsrs.DataContext);
        }
        private void RemoveDrink(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            cart.DrinksInCart.Remove((Drink)btnsrs.DataContext);
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

            PizzaSelect.Visibility = Visibility.Collapsed;
            EditPizzaMenu.Visibility = Visibility.Visible;
        }

        private void NewPizza(object sender, RoutedEventArgs e)
        {
            cart.PizzasInCart.Add(new Pizza("pizza"));
        }
        private void NewDrink(object sender, RoutedEventArgs e)
        {
            cart.DrinksInCart.Add(new Drink(Drinks.DrinksList[0].Name, Drinks.DrinksList[0].DrinkPrize));
        }
        private void AcceptPizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            thepiz.DataContext = ((Pizza)btnsrs.DataContext);

            pizza.SetBread(BreadDropdown.SelectedIndex);
            pizza.SetCheese(CheeseDropdown.SelectedIndex);
            pizza.SetSauce(SauceDropdown.SelectedIndex);
            pizza.IsLarge = LargeCheck.IsChecked.Value;

            PizzaSelect.Visibility = Visibility.Visible;
            EditPizzaMenu.Visibility = Visibility.Collapsed;
        }
        //private void NewPizza(object sender, RoutedEventArgs e)
        //{
        //    var btnsrs = (Button)sender;
        //    something.datacontext = ((Pizza)btnsrs.DataContext);
        //}
    }
}

