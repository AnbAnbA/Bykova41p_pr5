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

namespace Bykova41p_pr5
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

        private void RBDrev_Checked(object sender, RoutedEventArgs e)
        {
            CBDrev.Visibility=Visibility.Visible;
            SPDrev.Visibility=Visibility.Visible;
            SPYear.Visibility=Visibility.Collapsed;
            Bresult.Visibility=Visibility.Visible;
            CBDrev.IsEnabled = true;
            TBlResult.Text = "";
        }

        private void RBJapan_Checked(object sender, RoutedEventArgs e)
        {
            SPYear.Visibility = Visibility.Visible;
            SPDrev.Visibility = Visibility.Visible;
            CBDrev.Visibility = Visibility.Collapsed;
            Bresult.Visibility = Visibility.Visible;
            SPYear.IsEnabled = true;
            TBlResult.Text = "";
        }


        private void CBDrev_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBDrev.SelectedIndex) 
            {
                case 0:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 1:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 2:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 3:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 4:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 5:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 6:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 7:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 8:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 9:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 10:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;
                case 11:
                    TBlResult.Text = "";
                    TBDay.Text = "";
                    SPDay.Visibility = Visibility.Visible;
                    break;

            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (RBDrev.IsChecked == true) 
                {
                    switch (CBDrev.SelectedIndex) 
                    {
                        case 0:
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 30))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Мороз";
                            }
                            else if (Convert.ToInt32(TBDay.Text) == 31)
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Велес";
                            }
                            else 
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                                
                            break;
                        case 1:
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 28))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Велес";
                            }
                            else if (Convert.ToInt32(TBDay.Text) == 29)
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...Но если вы родились в високосный год, т.е. 29 февраля то у вас нет бога покровителя :))");
                            }
                            else 
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                          
                            break;
                        case 2:
                            
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Макошь";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 3:
                            
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 30))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Жива";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 4:
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 14))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Ярило";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 15) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Леля";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 5:
                            if (Convert.ToInt32(TBDay.Text) == 24)
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Иван Купало";
                            }
                            else if(((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 2)))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Леля";
                            }
                            else if (((Convert.ToInt32(TBDay.Text) >= 3) && (Convert.ToInt32(TBDay.Text) <= 12)))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Кострома";
                            }
                            else if (((Convert.ToInt32(TBDay.Text) >= 13) && (Convert.ToInt32(TBDay.Text) <= 30)))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Додола";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }

                            break;
                        case 6:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 6))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Додола";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 7) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Лада";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 7:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 28))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Перун";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 29) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Сева";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 8:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 13))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Сева";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 14) && (Convert.ToInt32(TBDay.Text) <= 27))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Рожаница";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 28) && (Convert.ToInt32(TBDay.Text) <= 30))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Сварожичи";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 9:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 15))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Сварожичи";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 16) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Морена";
                            }
                            else 
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 10:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 8))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Морена";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 9) && (Convert.ToInt32(TBDay.Text) <= 28))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Зима";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 29) && (Convert.ToInt32(TBDay.Text) <= 30))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Карачун";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;
                        case 11:
                            TBlResult.Text = "";
                            if ((Convert.ToInt32(TBDay.Text) >= 1) && (Convert.ToInt32(TBDay.Text) <= 23))
                            {
                                TBlResult.Text = "Вам покравительствует языческое божество Карачун";
                            }
                            else if ((Convert.ToInt32(TBDay.Text) >= 24) && (Convert.ToInt32(TBDay.Text) <= 31))
                            {

                                TBlResult.Text = "Вам покравительствует языческое божество Мороз";
                            }
                            else
                            {
                                TBlResult.Text = "";
                                MessageBox.Show("Вообще-то нет столько дней в месяце...");
                            }
                            break;

                    }
                }

                if (RBJapan.IsChecked == true) 
                {
                    if (Convert.ToInt32(TBYear.Text) % 12 == 0)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - обезьяна";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 1) 
                    {
                        TBlResult.Text = "По японскому календарю, Вы - петух";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 2)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - собака";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 3)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - кабан";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 4)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - крыса";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 5)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - вол";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 6)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - тигр";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 7)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - кролик";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 8)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - дракон";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 9)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - змея";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 10)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - лошадь";
                    }
                    else if (Convert.ToInt32(TBYear.Text) % 12 == 11)
                    {
                        TBlResult.Text = "По японскому календарю, Вы - овца";
                    }
                    else
                    {
                        TBlResult.Text = "";
                        MessageBox.Show("Что ты наделал...");
                    }
                }
            }
            catch { MessageBox.Show("Что-то не так.."); }

        }
    }
}
