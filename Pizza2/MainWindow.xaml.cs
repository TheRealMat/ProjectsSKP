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
            BreadDropdown.DataContext = Ingredients.BreadTypesList;

        }

        private void RemovePizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            cart.PizzasInCart.Remove((Pizza)btnsrs.DataContext);
        }

        private void EditPizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            thepiz.DataContext = ((Pizza)btnsrs.DataContext);
            pizza = ((Pizza)btnsrs.DataContext);
            BreadDropdown.SelectedIndex = pizza.Bread;

            PizzaSelect.Visibility = Visibility.Collapsed;
            EditPizzaMenu.Visibility = Visibility.Visible;
        }

        private void AcceptPizza(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            thepiz.DataContext = ((Pizza)btnsrs.DataContext);
            pizza.SetBread(BreadDropdown.SelectedIndex);

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

