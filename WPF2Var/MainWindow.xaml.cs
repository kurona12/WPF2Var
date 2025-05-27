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

namespace WPF2Var
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

        private void RasschetBtn_Click(object sender, RoutedEventArgs e)
        {
            int ves = Convert.ToInt32(VesTb.Text);
            int rost = Convert.ToInt32(RostTb.Text);

            double a = ves / ((rost /100) ^ 2);
            restb.Text = Convert.ToString(a);

            MessageBox.Show("Нормальный вес");
            return;
        }

    }
}
