using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtInput.Text);

            listBox.Items.Add("Recursive Fibonacci:");
            for (int i = 1; i <= n; i++)
                listBox.Items.Add(recFibo(i));

            loopFibo(n);
        }

        private void loopFibo(int n)
        {
            int[] a = new int[n + 1];

            listBox.Items.Add("Loop Fibonacci:");

            for (int i = 1; i <= n; i++)
                if (i == 1 || i == 2)
                    a[i] = 1;
                else
                    a[i] = a[i - 2] + a[i - 1];

            for (int i = 1; i <= n; i++)
                listBox.Items.Add(a[i]);
        }

        private int recFibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return recFibo(n - 1) + recFibo(n - 2);
        }
    }
}