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

namespace WpfApp79
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(dayTextBox.Text);
            int b = int.Parse(monthTextBox.Text);
            if (a == 1)
            {
                if (b == 1)
                {
                    a = 31;
                    b = 12;
                }
                else if (b == 3)
                {
                    a = 28;
                    b = 2;
                }
                else if (b == 5 || b == 7 || b == 10 || b == 12)
                {
                    a = 30;
                    b--;
                }
                else
                {
                    a = 31;
                    b--;
                }
            }
            else
            {
                a--;
            }
            txtOtv1.Content = a;
            txtOtv2.Content = b;

        }

    }
}
