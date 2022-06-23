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

namespace KCK_GUI
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
        // Play
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window playWindow = new Play();
            this.Close();
            playWindow.Show();
        }
        // Credits
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window creditWindow = new Credits();
            this.Close();
            creditWindow.Show();
        }
        // Exit
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
