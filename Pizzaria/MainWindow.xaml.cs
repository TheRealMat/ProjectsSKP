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

namespace Pizzaria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pizza selectedPizza;
        public MainWindow()
        {
            // here we make-a the molto bene little bambinos
            //pizzaTypes.AddPizza(new Pizza("Margherita", 5, new List<string>(){"tomato sauce", "mozzarella", "oregano"}));
            //pizzaTypes.AddPizza(new Pizza("Romana", 7, new List<string>() { "tomato sauce", "mozzarella", "anchovies", "capers", "oregano" }));
            //pizzaTypes.AddPizza(new Pizza("Prosciutto", 6, new List<string>() { "tomato sauce", "mozzarella", "ham", "oregano" }));

            




            InitializeComponent();
            // sets the pizzas list as databinding on the datatemplate
            lvDataBinding.ItemsSource = PizzaTypes.pizzas;


        }
        private void SelectPizza_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            selectedPizza = ((Pizza)btnsrs.DataContext);

        }
    }
}
