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
    /// Логика взаимодействия для practic1.xaml
    /// </summary>
    public partial class practic1 : Window
    {
        public practic1()
        {
            InitializeComponent();
            //tb1.Text = "Введите трехзначное\r\n      число";
        }

        private  void Bt1_Click(object sender, RoutedEventArgs e)
        {
            int s = 0, f = 0, y = 0;
           
            //int.TryParse(tb1.Text, out s);
            int.TryParse(tb1.Text, out s);

            if (tb1.Text == "")
            {
                TbError.Text = "Ошибка ввода\r\n введите число";
                tb1.Focus();
                //await Task.Delay(100);//спросить// уже сам все понял
            }
            else
                if (s == 0) { TbError.Text = "Ошибка ввода\r\n введите число без символов";
                    tb1.Clear();
                    tb2.Clear();
                    tb1.Focus();
                }
                else
            {
                //s = Convert.ToInt32(tb1.Text);
                
                string ss = Convert.ToString(s);
                while (true)// переделать
                {
                    f = s % 10;
                    s = s / 10;
                    y = y + f;
                    if (f == 0) { break; }
                }
                tb2.Text = Convert.ToString(y);
                
                if (ss.Length != 3)
                {
                    TbError.Text = "Ошибка ввода\r\n введите подходящее число";
                    tb1.Clear();
                    tb2.Clear();
                    tb1.Focus();
                }           //tb2.Text = ss;
            }
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            int s = 0, f = 0, y = 1;

            //int.TryParse(tb1.Text, out s);
            int.TryParse(tb1.Text, out s);

        if (tb1.Text == "")
            {
                TbError.Text = "Ошибка ввода\r\n введите число";
                tb1.Focus();
                //await Task.Delay(100);//спросить
            }
            else
            if (s == 0)
            {
                TbError.Text = "Ошибка ввода\r\n введите число без символов";
                tb1.Clear();
                tb2.Clear();
                tb1.Focus();
            }
            else
            {
                //s = Convert.ToInt32(tb1.Text);

                string ss = Convert.ToString(s);
                if (ss.Length != 3)
                {
                    TbError.Text = "Ошибка ввода\r\n введите подходящее число";
                    tb1.Clear();
                    tb2.Clear();
                    tb1.Focus();
                }
                else
                {
                    while (true)
                    {
                        f = s % 10;
                        s = s / 10;
                        ss = Convert.ToString(s);

                        y = y * f;

                        if (ss.Length == 1)
                        {
                            f = s % 10;
                            s = s / 10; y = y * f; break;
                        }
                    }
                    tb2.Text = Convert.ToString(y);
                }
                //tb2.Text = ss;
        }
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            TbError.Text = "";
        }

    }
}
