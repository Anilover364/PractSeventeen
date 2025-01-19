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
using System.Windows.Shapes;

namespace PractSeventeen
{
    /// <summary>
    /// Логика взаимодействия для Practic2.xaml
    /// </summary>
    public partial class Practic2 : Window
    {
        public Practic2()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            int A, B, C, AC,AA, BB, CC, BC,ABC;
            int.TryParse(tbA.Text, out A);
         AA=Math.Abs(A);
            int.TryParse(tbC.Text, out C);
            CC=Math.Abs(C);

            int.TryParse(tbB.Text, out B);
            BB=Math.Abs(B);

            if (tbA.Text == "")
            {
                tbError.Text = "Ошибка\r\nточка А не имеент значний";
                
                tbA.Focus();

            }
            else if (tbC.Text == "") 
            {
                tbError.Text = "Ошибка\r\nточка С не имеент значний";
                tbC.Focus();
            }
            else if (tbB.Text == "")
            {
                tbError.Text = "Ошибка\r\nточка В не имеент значний";
                tbB.Focus();
            }
            else 
            {
                if (A == 0)
                {
                    tbError.Text = "Ошибка\r\nвведите точку А цифрами";
                    tbA.Clear();
                    tbA.Focus();
                }
                else if (C == 0)
                {
                    tbError.Text = "Ошибка\r\nвведите точку C цифрами";
                    tbC.Clear();
                    tbC.Focus();
                }
                else if (B == 0)
                {
                    tbError.Text = "Ошибка\r\nвведите точку B цифрами";
                    tbB.Clear();
                    tbB.Focus();
                }
                else
                {
                    if (A > C || C > B || B < A)
                    {
                        tbA.Clear();
                        tbC.Clear();
                        tbB.Clear();
                        tbError.Text = "Ошибка\r\nнеправильно выставлены точки ";
                        tbA.Focus();

                    }
                    else
                    {
                        AC = AA + CC;
                        BC = BB + CC;
                        ABC = AC * BC;
                        tbAC.Text = Convert.ToString(AC);
                        tbBC.Text = Convert.ToString(BC);
                        tbABC.Text = Convert.ToString(ABC);
                    }
                }
             }
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            tbA.Clear();
            tbC.Clear();
            tbB.Clear();
            tbABC.Clear();
            tbAC.Clear();
            tbBC.Clear();
        }

        private void tbA_KeyDown(object sender, KeyEventArgs e)
        {
            tbError.Text = "";
        }

        private void tbC_KeyDown(object sender, KeyEventArgs e)
        {
            tbError.Text = "";
        }

     

        private void tbB_KeyDown(object sender, KeyEventArgs e)
        {
            tbError.Text = "";
        }
    }
}
