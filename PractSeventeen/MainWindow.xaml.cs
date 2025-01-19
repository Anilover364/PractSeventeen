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

namespace PractSeventeen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
            TB2.Visibility = Visibility.Hidden;
        }

        private async void BtP1_Click(object sender, RoutedEventArgs e)
        {
            
            {
                TB2.Visibility = Visibility.Visible;
                for (int i = 0; i < 3; i++)
                {
                    TB2.Text = TB2.Text + ".";
                    //await Task.Delay(1000);
                    await ShowMeWindow(); 
                }
                new Practic2().Show();
                this.Close();
            }
        }
        async Task ShowMeWindow()
        {
            await Task.Delay(100);
        }
            private async void BtP2_Click(object sender, RoutedEventArgs e)
        {
            TB2.Visibility = Visibility.Visible;
            for (int i = 0; i < 3; i++)
            {
                TB2.Text = TB2.Text + ".";
                //await Task.Delay(1000);
                await ShowMeWindow();

            }

            new practic1().Show();
            this.Close();
        }
    }
}
