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

namespace SearchFibonachi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vvodFibonachi.MaxLength = 55;
            resultFibonachi.IsReadOnly= true;
        }
        
        public static int Fibonacci(int n)
        {
            if(n<= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n-1)+Fibonacci(n-2);
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            

            if (vvodFibonachi.Text == "")
            {
                MessageBox.Show("Не введено число!");
            }
            else
            {
                int n = Convert.ToInt32(vvodFibonachi.Text);
                int result = Fibonacci(n);
                resultFibonachi.Text = result.ToString();
            }

        }

        private void vvodFibonachi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        }
    }
}
