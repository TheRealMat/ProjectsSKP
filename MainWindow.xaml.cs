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
using System.Data;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string entry;
        DataTable dt = new DataTable();
        public MainWindow()
        {
            InitializeComponent();






            Polygon p = new Polygon();
            p.Stroke = Brushes.Black;
            p.Fill = Brushes.LightBlue;
            p.StrokeThickness = 1;
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            p.Points = new PointCollection() { new Point(10, 0), new Point(-10, 0), new Point(-10, 10) };

            Canvas1.Children.Add(p);

        }

        private string Calculate(string entry)
        {
            string answer = "null";
            //https://www.c-sharpcorner.com/blogs/datatable-compute-method1
            try
            {
                answer = dt.Compute(entry, string.Empty).ToString();
            }
            catch
            {

            }
            return answer;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            entry = TextBox1.Text;
            TextBox1.Text = Calculate(entry);
        }

        // how am i gonna draw a cone on a 2d plane hmm
    }
}
