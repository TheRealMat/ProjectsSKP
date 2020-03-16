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
        public MainWindow()
        {
            InitializeComponent();
            DataTable dt = new DataTable();

            string entry;
            int answer;

            //https://www.c-sharpcorner.com/blogs/datatable-compute-method1
            try
            {
                answer = (int)dt.Compute("entry", "");
            }
            catch
            {

            }
        }

        // how am i gonna draw a cone on a 2d plane hmm
    }
}
