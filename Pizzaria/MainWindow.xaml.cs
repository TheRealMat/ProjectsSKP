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
        Pizza selectedPizza = new Pizza("Margherita", IngredientTypes.doughs[0], new List<Ingredient>() { IngredientTypes.toppings[1] }, new List<Ingredient>() { }, new List<Ingredient>() { IngredientTypes.sauces[0] }, new List<Ingredient> { IngredientTypes.spices[0] });
        public MainWindow()
        {
            // here we make-a the molto bene little bambinos
            //pizzaTypes.AddPizza(new Pizza("Margherita", 5, new List<string>(){"tomato sauce", "mozzarella", "oregano"}));
            //pizzaTypes.AddPizza(new Pizza("Romana", 7, new List<string>() { "tomato sauce", "mozzarella", "anchovies", "capers", "oregano" }));
            //pizzaTypes.AddPizza(new Pizza("Prosciutto", 6, new List<string>() { "tomato sauce", "mozzarella", "ham", "oregano" }));

            




            InitializeComponent();
            // sets the pizzas list as databinding on the datatemplate
            cmbColors.ItemsSource = PizzaTypes.pizzas;
            cheeses.ItemsSource = IngredientTypes.cheeses;
            doughs.ItemsSource = IngredientTypes.doughs;
            sauces.ItemsSource = IngredientTypes.sauces;
            spices.ItemsSource = IngredientTypes.spices;
            toppings.ItemsSource = IngredientTypes.toppings;






        }
        private void SelectPizza_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            selectedPizza = ((Pizza)btnsrs.DataContext);

        }
        private void SelectDoughs_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;
            selectedPizza.Dough = ((Ingredient)btnsrs.DataContext);

            // why the fuck does this fire when i click the other buttons
            testbox.Text = selectedPizza.Dough.IngredientName;


        }
        private void SelectSpices_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;


        }
        private void SelectCheeses_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;

        }
        private void SelectToppings_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;

        }
        private void SelectSauces_Click(object sender, RoutedEventArgs e)
        {
            var btnsrs = (Button)sender;

        }
    }
}
