using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using System.Windows.Threading;

namespace WpfApp2
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

        private void a_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = "";
            a.Visibility = Visibility.Collapsed;
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
            btn5.Visibility = Visibility.Visible;
            btn6.Visibility = Visibility.Visible;
            btn7.Visibility = Visibility.Visible;
            btn8.Visibility = Visibility.Visible;
            btn9.Visibility = Visibility.Visible;
            btn10.Visibility = Visibility.Visible;
            btn11.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn13.Visibility = Visibility.Visible;
            btn14.Visibility = Visibility.Visible;
            btn15.Visibility = Visibility.Visible;
            btn16.Visibility = Visibility.Visible;
            btn17.Visibility = Visibility.Visible;
            btn18.Visibility = Visibility.Visible;
            btn19.Visibility = Visibility.Visible;
            btn20.Visibility = Visibility.Visible;
            btn21.Visibility = Visibility.Visible;
            btn22.Visibility = Visibility.Visible;
            btn23.Visibility = Visibility.Visible;
            btn24.Visibility = Visibility.Visible;
            btn25.Visibility = Visibility.Visible;
            btn26.Visibility = Visibility.Visible;
            btn27.Visibility = Visibility.Visible;
            btn28.Visibility = Visibility.Visible;
            btn29.Visibility = Visibility.Visible;
            btn30.Visibility = Visibility.Visible;
            btn31.Visibility = Visibility.Visible;
            btn32.Visibility = Visibility.Visible;
            btn33.Visibility = Visibility.Visible;
            btn34.Visibility = Visibility.Visible;
            btn35.Visibility = Visibility.Visible;
            btn36.Visibility = Visibility.Visible;
            btn37.Visibility = Visibility.Visible;
            btn38.Visibility = Visibility.Visible;
            btn39.Visibility = Visibility.Visible;
            btn40.Visibility = Visibility.Visible;
            btn41.Visibility = Visibility.Visible;
            btn42.Visibility = Visibility.Visible;
            btn43.Visibility = Visibility.Visible;
            btn44.Visibility = Visibility.Visible;
            btn45.Visibility = Visibility.Visible;
            btnback.Visibility = Visibility.Visible;


        }



        private bool isButtonClicked = false;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            tack1.Visibility = Visibility.Visible;
            task1_1.Visibility = Visibility.Visible;
            task1_2.Visibility = Visibility.Visible;
            task1_3.Visibility = Visibility.Visible;
        }

        private void task1_1_Click_1(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool A = true, B = false, C = false, Z;
            Z = (A && !A || B) && C;
            if (Z == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task1_2_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool A1 = true, B1 = false, C1 = false, Z1;
            Z1 = !A1 && A1 || (B1 && C1);
            if (Z1 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task1_3_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool A2 = true, B2 = false, C2 = false, Z2;
            Z2 = (A2 && B2 || !C2) || C2;
            if (Z2 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }


        private void task2_1_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool y = true, x = false, z = false, Q;
            Q = x && !(x || y) || !z;
            if (Q == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task2_2_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool y1 = true, x1 = false, z1 = false, Q1;
            Q1 = !x1 || x1 && (y1 || z1);
            if (Q1 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task2_3_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool y2 = true, x2 = false, z2 = false, Q2;
            Q2 = (x2 || y2 && !z2) && z2;
            if (Q2 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            tack2.Visibility = Visibility.Visible;
            task2_1.Visibility = Visibility.Visible;
            task2_2.Visibility = Visibility.Visible;
            task2_3.Visibility = Visibility.Visible;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            task3.Visibility = Visibility.Visible;
            task3_5.Visibility = Visibility.Visible;
            task3_1.Visibility = Visibility.Visible;
            task3_2.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            task3_3.Visibility = Visibility.Visible;
            task3_4.Visibility = Visibility.Visible;

        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {

            if (task3_1.Text == "0")
            {
                task3_1.Background = Brushes.LightGreen;
            }
            else
            {
                task3_1.Background = Brushes.Red;
            }
            if (task3_2.Text == "1")
            {
                task3_2.Background = Brushes.LightGreen;
            }
            else
            {
                task3_2.Background = Brushes.Red;
            }
            if (task3_2.Text == "1" && task3_1.Text == "0")
            {
                Check.Content = "Верно";
                Check.Foreground = Brushes.Black;
                Check.Background = Brushes.LightGreen;
            }
            else if (task3_2.Text == "1" || task3_1.Text == "0")
            {
                Check.Content = "Где-то ошибка";
                Check.Background = Brushes.Yellow;
                Check.Foreground = Brushes.Black;
            }
            else
            {
                Check.Content = "не верно";
                Check.Background = Brushes.Red;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            task4.Visibility = Visibility.Visible;
            task4_1.Visibility = Visibility.Visible;
            task4_2.Visibility = Visibility.Visible;
            Check1.Visibility = Visibility.Visible;
        }

        private void Check1_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(task4_2.Text))
            {
                int number = Convert.ToInt32(task4_2.Text);

                if (number % 2 == 0 || number % 3 == 0)
                {
                    task4_2.Background = Brushes.LightGreen;
                    Check1.Content = "Верно";
                    Check1.Foreground = Brushes.Black;
                    Check1.Background = Brushes.LightGreen;
                }
                else
                {
                    task4_2.Background = Brushes.Red;
                    Check1.Content = "не верно";
                    Check1.Background = Brushes.Red;
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            task5.Visibility = Visibility.Visible;
            task5_1.Visibility = Visibility.Visible;
            task5_2.Visibility = Visibility.Visible;
            Check2.Visibility = Visibility.Visible;
            task5_3.Visibility = Visibility.Visible;
            task5_4.Visibility = Visibility.Visible;
        }

        private void Check2_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(task5_2.Text);
            int number2 = Convert.ToInt32(task5_4.Text);

            if ((number2 % 2 != 0))
            {
                task5_4.Background = Brushes.LightGreen;
            }
            else
            {
                task5_4.Background = Brushes.Red;
            }
            if ((number % 2 != 0))
            {
                task5_2.Background = Brushes.LightGreen;
            }
            else
            {
                task5_2.Background = Brushes.Red;
            }

            if ((number2 % 2 != 0) && (number % 2 != 0))
            {
                Check2.Content = "Верно";
                Check2.Foreground = Brushes.Black;
                Check2.Background = Brushes.LightGreen;
            }
            else
            {
                Check2.Content = "не верно";
                Check2.Background = Brushes.Red;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task6.Visibility = Visibility.Visible;
            task6_1.Visibility = Visibility.Visible;
            task6_2.Visibility = Visibility.Visible;
            task6_3.Visibility = Visibility.Visible;

        }

        private void task6_1_Click(object sender, RoutedEventArgs e)
        {
            {
                if (isButtonClicked)
                {
                    return;
                }

                isButtonClicked = true;

                bool y1 = true, x1 = false, z1 = false, O;
                O = x1 || y1 && !z1;
                if (O == true)
                {
                    True.Visibility = Visibility.Visible;
                }
                else
                {
                    False.Visibility = Visibility.Visible;
                }
            }
        }

        private void task6_2_Click(object sender, RoutedEventArgs e)
        {
            {
                if (isButtonClicked)
                {
                    return;
                }

                isButtonClicked = true;

                bool y1 = true, x1 = false, O;
                O = !x1 && !y1;
                if (O == true)
                {
                    True.Visibility = Visibility.Visible;
                }
                else
                {
                    False.Visibility = Visibility.Visible;
                }
            }
        }

        private void task6_3_Click(object sender, RoutedEventArgs e)
        {
            {
                if (isButtonClicked)
                {
                    return;
                }

                isButtonClicked = true;

                bool y1 = true, x1 = false, z1 = false, O;
                O = !(x1 && z1) || y1;
                if (O == true)
                {
                    True.Visibility = Visibility.Visible;
                }
                else
                {
                    False.Visibility = Visibility.Visible;
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task7.Visibility = Visibility.Visible;
            da.Visibility = Visibility.Visible;
            net.Visibility = Visibility.Visible;
        }

        private void da_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }
            isButtonClicked = true;

            lopata.Visibility = Visibility.Visible;
        }

        private void net_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }
            isButtonClicked = true;

            kocherga.Visibility = Visibility.Visible;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            task8.Visibility = Visibility.Visible;
            task8_1.Visibility = Visibility.Visible;
            task8_2.Visibility = Visibility.Visible;
            task8_3.Visibility = Visibility.Visible;
            task8_4.Visibility = Visibility.Visible;
            task8_5.Visibility = Visibility.Visible;
            Check3.Visibility = Visibility.Visible;
        }

        private void Check3_Click(object sender, RoutedEventArgs e)
        {
            {

                if (task8_3.Text == "1")
                {
                    task8_3.Background = Brushes.LightGreen;
                }
                else
                {
                    task8_3.Background = Brushes.Red;
                }
                if (task8_5.Text == "0")
                {
                    task8_5.Background = Brushes.LightGreen;
                }
                else
                {
                    task8_5.Background = Brushes.Red;
                }
                if (task8_3.Text == "1" && task8_5.Text == "0")
                {
                    Check3.Content = "Верно";
                    Check3.Foreground = Brushes.Black;
                    Check3.Background = Brushes.LightGreen;
                }
                else if (task8_3.Text == "1" || task8_5.Text == "0")
                {
                    Check3.Content = "Где-то ошибка";
                    Check3.Background = Brushes.Yellow;
                    Check3.Foreground = Brushes.Black;
                }
                else
                {
                    Check3.Content = "не верно";
                    Check3.Background = Brushes.Red;
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            task9.Visibility = Visibility.Visible;
            task9_1.Visibility = Visibility.Visible;
            task9_2.Visibility = Visibility.Visible;
            task9_3.Visibility = Visibility.Visible;
            task9_4.Visibility = Visibility.Visible;
            task9_5.Visibility = Visibility.Visible;
            Check4.Visibility = Visibility.Visible;
        }

        private void Check4_Click(object sender, RoutedEventArgs e)
        {
            if (task9_3.Text == "1")
            {
                task9_3.Background = Brushes.LightGreen;
            }
            else
            {
                task9_3.Background = Brushes.Red;
            }
            if (task9_5.Text == "1")
            {
                task9_5.Background = Brushes.LightGreen;
            }
            else
            {
                task9_5.Background = Brushes.Red;
            }
            if (task9_3.Text == "1" && task9_5.Text == "1")
            {
                Check4.Content = "Верно";
                Check4.Foreground = Brushes.Black;
                Check4.Background = Brushes.LightGreen;
            }
            else if (task9_3.Text == "1" || task9_5.Text == "1")
            {
                Check4.Content = "Где-то ошибка";
                Check4.Background = Brushes.Yellow;
                Check4.Foreground = Brushes.Black;
            }
            else
            {
                Check4.Content = "не верно";
                Check4.Background = Brushes.Red;
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task10.Visibility = Visibility.Visible;
            task10_1.Visibility = Visibility.Visible;
            task10_2.Visibility = Visibility.Visible;
            task10_3.Visibility = Visibility.Visible;
        }

        private void task10_1_Click(object sender, RoutedEventArgs e)
        {

            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a1 = true, b1 = false, c1 = false, L;
            L = a1 || !(a1 && b1) || c1;
            if (L == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }

        }

        private void task10_2_Click(object sender, RoutedEventArgs e)
        {

            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a1 = true, b1 = false, c1 = false, L;
            L = !a1 || c1 && !(b1 || c1);
            if (L == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }

        }

        private void task10_3_Click(object sender, RoutedEventArgs e)
        {

            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a1 = true, b1 = false, c1 = false, L;
            L = (a1 || b1 && !c1) || a1;
            if (L == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }

        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            task11.Visibility = Visibility.Visible;
            task11_1.Visibility = Visibility.Visible;
            task11_2.Visibility = Visibility.Visible;
            task11_3.Visibility = Visibility.Visible;
            task11_4.Visibility = Visibility.Visible;
            task11_5.Visibility = Visibility.Visible;
            Check5.Visibility = Visibility.Visible;
        }

        private void Check5_Click(object sender, RoutedEventArgs e)
        {
            if (task11_3.Text == "1")
            {
                task11_3.Background = Brushes.LightGreen;
            }
            else
            {
                task11_3.Background = Brushes.Red;
            }
            if (task11_5.Text == "1")
            {
                task11_5.Background = Brushes.LightGreen;
            }
            else
            {
                task11_5.Background = Brushes.Red;
            }
            if (task11_3.Text == "1" && task11_5.Text == "1")
            {
                Check5.Content = "Верно";
                Check5.Foreground = Brushes.Black;
                Check5.Background = Brushes.LightGreen;
            }
            else if (task11_3.Text == "1" || task11_5.Text == "1")
            {
                Check5.Content = "Где-то ошибка";
                Check5.Background = Brushes.Yellow;
                Check5.Foreground = Brushes.Black;
            }
            else
            {
                Check5.Content = "не верно";
                Check5.Background = Brushes.Red;
            }
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            task12.Visibility = Visibility.Visible;
            task12_1.Visibility = Visibility.Visible;
            task12_2.Visibility = Visibility.Visible;
            Check6.Visibility = Visibility.Visible;
        }

        private void btnback_Click_1(object sender, RoutedEventArgs e)
        {
            True.Visibility = Visibility.Collapsed;
            False.Visibility = Visibility.Collapsed;
            tack1.Visibility = Visibility.Collapsed;
            task1_1.Visibility = Visibility.Collapsed;
            task1_2.Visibility = Visibility.Collapsed;
            task1_3.Visibility = Visibility.Collapsed;
            tack2.Visibility = Visibility.Collapsed;
            task2_1.Visibility = Visibility.Collapsed;
            task2_2.Visibility = Visibility.Collapsed;
            task2_3.Visibility = Visibility.Collapsed;
            task3.Visibility = Visibility.Collapsed;
            task3_1.Visibility = Visibility.Collapsed;
            task3_2.Visibility = Visibility.Collapsed;
            task3_3.Visibility = Visibility.Collapsed;
            task3_4.Visibility = Visibility.Collapsed;
            task3_5.Visibility = Visibility.Collapsed;
            Check.Visibility = Visibility.Collapsed;
            task4.Visibility = Visibility.Collapsed;
            task4_1.Visibility = Visibility.Collapsed;
            task4_2.Visibility = Visibility.Collapsed;
            Check1.Visibility = Visibility.Collapsed;
            task5.Visibility = Visibility.Collapsed;
            task5_1.Visibility = Visibility.Collapsed;
            task5_2.Visibility = Visibility.Collapsed;
            Check2.Visibility = Visibility.Collapsed;
            task5_3.Visibility = Visibility.Collapsed;
            task5_4.Visibility = Visibility.Collapsed;
            task6.Visibility = Visibility.Collapsed;
            task6_1.Visibility = Visibility.Collapsed;
            task6_2.Visibility = Visibility.Collapsed;
            task6_3.Visibility = Visibility.Collapsed;
            task7.Visibility = Visibility.Collapsed;
            da.Visibility = Visibility.Collapsed;
            net.Visibility = Visibility.Collapsed;
            kocherga.Visibility = Visibility.Collapsed;
            lopata.Visibility = Visibility.Collapsed;
            task8.Visibility = Visibility.Collapsed;
            task8_1.Visibility = Visibility.Collapsed;
            task8_2.Visibility = Visibility.Collapsed;
            task8_3.Visibility = Visibility.Collapsed;
            task8_4.Visibility = Visibility.Collapsed;
            task8_5.Visibility = Visibility.Collapsed;
            Check3.Visibility = Visibility.Collapsed;
            task9.Visibility = Visibility.Collapsed;
            task9_1.Visibility = Visibility.Collapsed;
            task9_2.Visibility = Visibility.Collapsed;
            task9_3.Visibility = Visibility.Collapsed;
            task9_4.Visibility = Visibility.Collapsed;
            task9_5.Visibility = Visibility.Collapsed;
            Check4.Visibility = Visibility.Collapsed;
            task10.Visibility = Visibility.Collapsed;
            task10_1.Visibility = Visibility.Collapsed;
            task10_2.Visibility = Visibility.Collapsed;
            task10_3.Visibility = Visibility.Collapsed;
            task11.Visibility = Visibility.Collapsed;
            task11_1.Visibility = Visibility.Collapsed;
            task11_2.Visibility = Visibility.Collapsed;
            task11_3.Visibility = Visibility.Collapsed;
            task11_4.Visibility = Visibility.Collapsed;
            task11_5.Visibility = Visibility.Collapsed;
            Check5.Visibility = Visibility.Collapsed;
            task12.Visibility = Visibility.Collapsed;
            task12_1.Visibility = Visibility.Collapsed;
            task12_2.Visibility = Visibility.Collapsed;
            Check6.Visibility = Visibility.Collapsed;
            task131.Visibility = Visibility.Collapsed;
            task13_1.Visibility = Visibility.Collapsed;
            task13_2.Visibility = Visibility.Collapsed;
            task13_3.Visibility = Visibility.Collapsed;
            task13_4.Visibility = Visibility.Collapsed;
            task13_5.Visibility = Visibility.Collapsed;
            task13_6.Visibility = Visibility.Collapsed;
            Check7.Visibility = Visibility.Collapsed;
            task14.Visibility = Visibility.Collapsed;
            task14_1.Visibility = Visibility.Collapsed;
            task14_2.Visibility = Visibility.Collapsed;
            Check8.Visibility = Visibility.Collapsed;
            task15.Visibility = Visibility.Collapsed;
            task15_1.Visibility = Visibility.Collapsed;
            task15_2.Visibility = Visibility.Collapsed;
            Check9.Visibility = Visibility.Collapsed;
            task16.Visibility = Visibility.Collapsed;
            task16_1.Visibility = Visibility.Collapsed;
            task16_2.Visibility = Visibility.Collapsed;
            task16_3.Visibility = Visibility.Collapsed;
            task16_4.Visibility = Visibility.Collapsed;
            task16_5.Visibility = Visibility.Collapsed;
            task16_6.Visibility = Visibility.Collapsed;
            Check10.Visibility = Visibility.Collapsed;
            task17.Visibility = Visibility.Collapsed;
            task17_1.Visibility = Visibility.Collapsed;
            task17_2.Visibility = Visibility.Collapsed;
            task17_3.Visibility = Visibility.Collapsed;
            task18.Visibility = Visibility.Collapsed;
            task18_1.Visibility = Visibility.Collapsed;
            task18_2.Visibility = Visibility.Collapsed;
            task18_3.Visibility = Visibility.Collapsed;
            task19.Visibility = Visibility.Collapsed;
            task19_1.Visibility = Visibility.Collapsed;
            task19_2.Visibility = Visibility.Collapsed;
            task19_3.Visibility = Visibility.Collapsed;
            task19_4.Visibility = Visibility.Collapsed;
            task19_5.Visibility = Visibility.Collapsed;
            task19_6.Visibility = Visibility.Collapsed;
            Check11.Visibility = Visibility.Collapsed;
            task20.Visibility = Visibility.Collapsed;
            task20_1.Visibility = Visibility.Collapsed;
            task20_2.Visibility = Visibility.Collapsed;
            task20_3.Visibility = Visibility.Collapsed;
            task20_4.Visibility = Visibility.Collapsed;
            Check12.Visibility = Visibility.Collapsed;
            task21.Visibility = Visibility.Collapsed;
            task21_1.Visibility = Visibility.Collapsed;
            task21_2.Visibility = Visibility.Collapsed;
            task21_3.Visibility = Visibility.Collapsed;
            task22.Visibility = Visibility.Collapsed;
            task22_1.Visibility = Visibility.Collapsed;
            task22_2.Visibility = Visibility.Collapsed;
            task22_3.Visibility = Visibility.Collapsed;
            task22_4.Visibility = Visibility.Collapsed;
            Check13.Visibility = Visibility.Collapsed;
            task23.Visibility = Visibility.Collapsed;
            task23_1.Visibility = Visibility.Collapsed;
            task23_2.Visibility = Visibility.Collapsed;
            Check14.Visibility = Visibility.Collapsed;
            task24.Visibility = Visibility.Collapsed;
            task24_1.Visibility = Visibility.Collapsed;
            task24_2.Visibility = Visibility.Collapsed;
            Check15.Visibility = Visibility.Collapsed;
            task25.Visibility = Visibility.Collapsed;
            task25_1.Visibility = Visibility.Collapsed;
            task25_2.Visibility = Visibility.Collapsed;
            task25_3.Visibility = Visibility.Collapsed;
            task25_4.Visibility = Visibility.Collapsed;
            task25_5.Visibility = Visibility.Collapsed;
            task25_6.Visibility = Visibility.Collapsed;
            task25_7.Visibility = Visibility.Collapsed;
            task25_8.Visibility = Visibility.Collapsed;
            task25_9.Visibility = Visibility.Collapsed;
            task25_10.Visibility = Visibility.Collapsed;
            Check25.Visibility = Visibility.Collapsed;
            Check16.Visibility = Visibility.Collapsed;
            task26.Visibility = Visibility.Collapsed;
            task26_1.Visibility = Visibility.Collapsed;
            task26_2.Visibility = Visibility.Collapsed;
            task26_3.Visibility = Visibility.Collapsed;
            task26_4.Visibility = Visibility.Collapsed;
            Check17.Visibility = Visibility.Collapsed;
            task27.Visibility = Visibility.Collapsed;
            task27_1.Visibility = Visibility.Collapsed;
            task27_2.Visibility = Visibility.Collapsed;
            task27_3.Visibility = Visibility.Collapsed;
            task27_4.Visibility = Visibility.Collapsed;
            task28.Visibility = Visibility.Collapsed;
            task28_1.Visibility = Visibility.Collapsed;
            task28_2.Visibility = Visibility.Collapsed;
            Check28.Visibility = Visibility.Collapsed;
            task29.Visibility = Visibility.Collapsed;
            task29_1.Visibility = Visibility.Collapsed;
            task29_2.Visibility = Visibility.Collapsed;
            Check29.Visibility = Visibility.Collapsed;
            task30.Visibility = Visibility.Collapsed;
            task30_1.Visibility = Visibility.Collapsed;
            task30_2.Visibility = Visibility.Collapsed;
            task30_3.Visibility = Visibility.Collapsed;
            task30_4.Visibility = Visibility.Collapsed;
            Check30.Visibility = Visibility.Collapsed;
            task31.Visibility = Visibility.Collapsed;
            task31_1.Visibility = Visibility.Collapsed;
            task31_2.Visibility = Visibility.Collapsed;
            task31_3.Visibility = Visibility.Collapsed;
            task31_4.Visibility = Visibility.Collapsed;
            task31_5.Visibility = Visibility.Collapsed;
            task31_6.Visibility = Visibility.Collapsed;
            task31_7.Visibility = Visibility.Collapsed;
            task31_8.Visibility = Visibility.Collapsed;
            task31_9.Visibility = Visibility.Collapsed;
            task31_10.Visibility = Visibility.Collapsed;
            task31_11.Visibility = Visibility.Collapsed;
            task31_12.Visibility = Visibility.Collapsed;
            Check31.Visibility = Visibility.Collapsed;
            task34.Visibility = Visibility.Collapsed;
            TimerTextBlock.Visibility = Visibility.Collapsed;
            task34_1.Visibility = Visibility.Collapsed;
            task0.Visibility = Visibility.Collapsed;
            task43.Visibility = Visibility.Collapsed;
            dkit.Visibility = Visibility.Collapsed;
            dpk.Visibility = Visibility.Collapsed;
            horosh.Visibility = Visibility.Collapsed;
            otchis.Visibility = Visibility.Collapsed;
            task44.Visibility = Visibility.Collapsed;
            riba.Visibility = Visibility.Collapsed;
            myaso.Visibility = Visibility.Collapsed;
            chipi.Visibility = Visibility.Collapsed;
            chapa.Visibility = Visibility.Collapsed;
            task45.Visibility = Visibility.Collapsed;
            top.Visibility = Visibility.Collapsed;
            luchiy.Visibility = Visibility.Collapsed;
            verno.Visibility = Visibility.Collapsed;


        }

        private void Check6_Click(object sender, RoutedEventArgs e)
        {
            int number = 0;
            if (!int.TryParse(task12_2.Text, out number))
            {
                task12_2.Background = Brushes.Red;
                Check6.Content = "не верно";
                Check6.Background = Brushes.Red;
            }

            bool isThreeDigitNumber = number >= 100 && number <= 999;

            if (isThreeDigitNumber)
            {
                task12_2.Background = Brushes.LightGreen;
                Check6.Content = "Верно";
                Check6.Foreground = Brushes.Black;
                Check6.Background = Brushes.LightGreen;
            }
            else
            {
                task12_2.Background = Brushes.Red;
                Check6.Content = "не верно";
                Check6.Background = Brushes.Red;
            }
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            task131.Visibility = Visibility.Visible;
            task13_1.Visibility = Visibility.Visible;
            task13_2.Visibility = Visibility.Visible;
            task13_3.Visibility = Visibility.Visible;
            task13_4.Visibility = Visibility.Visible;
            task13_5.Visibility = Visibility.Visible;
            task13_6.Visibility = Visibility.Visible;
            Check7.Visibility = Visibility.Visible;
        }

        private void Check7_Click(object sender, RoutedEventArgs e)
        {
            int a13, b13, c13;
            int.TryParse(task13_2.Text, out a13);
            int.TryParse(task13_4.Text, out b13);
            int.TryParse(task13_6.Text, out c13);

            if ((a13 < 45 && b13 >= 45 && c13 >= 45) || (b13 < 45 && a13 >= 45 && c13 >= 45) || (c13 < 45 && a13 >= 45 && b13 >= 45))
            {
                Check7.Content = "Верно";
                Check7.Foreground = Brushes.Black;
                Check7.Background = Brushes.LightGreen;
            }
            else
            {
                Check7.Content = "не верно";
                Check7.Background = Brushes.Red;
            }
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            task14.Visibility = Visibility.Visible;
            task14_1.Visibility = Visibility.Visible;
            task14_2.Visibility = Visibility.Visible;
            Check8.Visibility = Visibility.Visible;
        }

        private void Check8_Click(object sender, RoutedEventArgs e)
        {
            int a14;
            int.TryParse(task14_2.Text, out a14);
            if (a14 % 3 != 0 && a14 % 10 == 0)
                {
                    Check8.Content = "Верно";
                    Check8.Foreground = Brushes.Black;
                    Check8.Background = Brushes.LightGreen;
                    task14_2.Background = Brushes.LightGreen;
                }
            else
            {
                Check8.Content = "не верно";
                Check8.Background = Brushes.Red;
                task14_2.Background = Brushes.Red;
            }
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            task15.Visibility = Visibility.Visible;
            task15_1.Visibility = Visibility.Visible;
            task15_2.Visibility = Visibility.Visible;
            Check9.Visibility = Visibility.Visible;
        }

        private void Check9_Click(object sender, RoutedEventArgs e)
        {
            int a15;
            int.TryParse(task15_2.Text, out a15);
            if (a15 > -136 && a15 < -50)
            {
                Check9.Content = "Верно";
                Check9.Foreground = Brushes.Black;
                Check9.Background = Brushes.LightGreen;
                task15_2.Background = Brushes.LightGreen;
            }
            else if (a15 > 54 && a15 < 124)
            {
                Check9.Content = "Верно";
                Check9.Foreground = Brushes.Black;
                Check9.Background = Brushes.LightGreen;
                task15_2.Background = Brushes.LightGreen;
            }
            else
            {
                Check9.Content = "не верно";
                Check9.Background = Brushes.Red;
                task15_2.Background = Brushes.Red;
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            task16.Visibility = Visibility.Visible;
            task16_1.Visibility = Visibility.Visible;
            task16_2.Visibility = Visibility.Visible;
            task16_3.Visibility = Visibility.Visible;
            task16_4.Visibility = Visibility.Visible;
            task16_5.Visibility = Visibility.Visible;
            task16_6.Visibility = Visibility.Visible;
            Check10.Visibility = Visibility.Visible;
        }

        private void Check10_Click(object sender, RoutedEventArgs e)
        {
            int a16, b16, c16;
            int.TryParse(task16_4.Text, out a16);
            int.TryParse(task16_5.Text, out b16);
            int.TryParse(task16_6.Text, out c16);

            if (a16 % 5 == 0 && b16 % 5 != 0 && c16 % 5 != 0)
            {
                Check10.Content = "Верно";
                Check10.Foreground = Brushes.Black;
                Check10.Background = Brushes.LightGreen;
            }
            else if (a16 % 5 != 0 && b16 % 5 == 0 && c16 % 5 != 0)
            {
                Check10.Content = "Верно";
                Check10.Foreground = Brushes.Black;
                Check10.Background = Brushes.LightGreen;
            }
            else if (a16 % 5 != 0 && b16 % 5 != 0 && c16 % 5 == 0)
            {
                Check10.Content = "Верно";
                Check10.Foreground = Brushes.Black;
                Check10.Background = Brushes.LightGreen;
            }
            else
            {
                Check10.Content = "не верно";
                Check10.Background = Brushes.Red;
            }
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task17.Visibility = Visibility.Visible;
            task17_1.Visibility = Visibility.Visible;
            task17_2.Visibility = Visibility.Visible;
            task17_3.Visibility = Visibility.Visible;
        }

        private void task17_1_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a17 = true, b17 = false, c17 = false, R;
            R = a17 && !b17 || c17;
            if (R == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }

        }
    

        private void task17_2_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a17 = true, b17 = false, c17 = false, R;
            R = a17 && (!b17 || c17);
            if (R == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task17_3_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a17 = true, b17 = false, c17 = false, R;
            R = a17 || (!(b17 && c17));
            if (R == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task18.Visibility = Visibility.Visible;
            task18_1.Visibility = Visibility.Visible;
            task18_2.Visibility = Visibility.Visible;
            task18_3.Visibility = Visibility.Visible;
        }

        private void task18_1_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a18 = false, b18 = false, c18 = true, S;
            S = (!a18 || !b18) && !c18;
            if (S == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task18_2_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a18 = false, b18 = false, S;
            S = (!a18 || !b18) && (a18 || b18);
            if (S == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task18_3_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool a18 = false, b18 = false, c18 = true, S;
            S = a18 && b18 || a18 && c18 || !c18;
            if (S == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            task19.Visibility = Visibility.Visible;
            task19_1.Visibility = Visibility.Visible;
            task19_2.Visibility = Visibility.Visible;
            task19_3.Visibility = Visibility.Visible;
            task19_4.Visibility = Visibility.Visible;
            task19_5.Visibility = Visibility.Visible;
            task19_6.Visibility = Visibility.Visible;
            Check11.Visibility = Visibility.Visible;
        }

        private void Check11_Click(object sender, RoutedEventArgs e)
        {
            int a19, b19, c19;
            int.TryParse(task19_4.Text, out a19);
            int.TryParse(task19_5.Text, out b19);
            int.TryParse(task19_6.Text, out c19);

            if ((a19 > 80 && b19 <= 80 && c19 <= 80) || (a19 <= 80 && b19 > 80 && c19 <= 80) || (a19 <= 80 && b19 <= 80 && c19 > 80))
            {
                Check11.Content = "Верно";
                Check11.Foreground = Brushes.Black;
                Check11.Background = Brushes.LightGreen;
            }

            
            else
            {
                Check11.Content = "не верно";
                Check11.Background = Brushes.Red;
            }
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            task20.Visibility = Visibility.Visible;
            task20_1.Visibility = Visibility.Visible;
            task20_2.Visibility = Visibility.Visible;
            task20_3.Visibility = Visibility.Visible;
            task20_4.Visibility = Visibility.Visible;
            Check12.Visibility = Visibility.Visible;
        }

        private void Check12_Click(object sender, RoutedEventArgs e)
        {
            int x20, y20;
            int.TryParse(task20_2.Text, out x20);
            int.TryParse(task20_4.Text, out y20);

            bool isY1Defined = true; 
            bool isY2Defined = true;


            double expression1 = 1 - Math.Cos(3 * x20);
            if (double.IsNaN(expression1) || double.IsInfinity(expression1))
            {
                isY1Defined = false;
            }

            double expression2 = y20 / Math.Pow(y20 - 3, 2);
            if (double.IsNaN(expression2) || double.IsInfinity(expression2))
            {
                isY2Defined = false;
            }


            if (isY1Defined)
            {

                task20_2.Background = Brushes.LightGreen;
                Check12.Content = "Верно";
                Check12.Foreground = Brushes.Black;
                Check12.Background = Brushes.LightGreen;

            }
            else
            {
                task20_2.Background = Brushes.Red;
                Check12.Content = "не верно";
                Check12.Background = Brushes.Red;
            }

            if (isY2Defined)
            {
                task20_4.Background = Brushes.LightGreen;
                Check12.Content = "Верно";
                Check12.Foreground = Brushes.Black;
                Check12.Background = Brushes.LightGreen;
            }
            else
            {

                task20_4.Background = Brushes.Red;
                Check12.Content = "не верно";
                Check12.Background = Brushes.Red;
            }
        }

        private void task21_3_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool x21 = false, y21 = false, z21 = true, S1;
            S1 = x21 || (!(y21 && z21));
            if (S1 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task21_2_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool x21 = false, y21 = false, z21 = true, S1;
            S1 = x21 && (!y21 || z21);
            if (S1 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void task21_1_Click(object sender, RoutedEventArgs e)
        {
            if (isButtonClicked)
            {
                return;
            }

            isButtonClicked = true;

            bool x21 = false, y21 = false, z21 = true, S1;
            S1 = (x21 && !y21) || z21;
            if (S1 == true)
            {
                True.Visibility = Visibility.Visible;
            }
            else
            {
                False.Visibility = Visibility.Visible;
            }
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            isButtonClicked = false;
            task21.Visibility = Visibility.Visible;
            task21_1.Visibility = Visibility.Visible;
            task21_2.Visibility = Visibility.Visible;
            task21_3.Visibility = Visibility.Visible;
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            task22.Visibility = Visibility.Visible;
            task22_1.Visibility = Visibility.Visible;
            task22_2.Visibility = Visibility.Visible;
            task22_3.Visibility = Visibility.Visible;
            task22_4.Visibility = Visibility.Visible;
            Check13.Visibility = Visibility.Visible;
        }

        private void Check13_Click(object sender, RoutedEventArgs e)
        {
            int x22, y22;
            int.TryParse(task22_2.Text, out x22);
            int.TryParse(task22_4.Text, out y22);

          bool result = ((x22 >= -5 && x22 < 5) && (-3.5 < y22 && y22 <= 8.1 && y22 != 0));
            if (result)
            {
                Check13.Content = "Верно";
                Check13.Foreground = Brushes.Black;
                Check13.Background = Brushes.LightGreen;
            }
            else
            {
                Check13.Content = "не верно";
                Check13.Background = Brushes.Red;
            }
        }

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            task23.Visibility = Visibility.Visible;
            task23_1.Visibility = Visibility.Visible;
            task23_2.Visibility = Visibility.Visible;
            Check14.Visibility = Visibility.Visible;
        }

        private void Check14_Click(object sender, RoutedEventArgs e)
        {
            int a23;
            int.TryParse(task23_2.Text, out a23);

            if (a23 > -10 && a23 < -1)
            {
                Check14.Content = "Верно";
                Check14.Foreground = Brushes.Black;
                Check14.Background = Brushes.LightGreen;
                task23_2.Background = Brushes.LightGreen;
            }
            else if (a23 > 2 && a23 < 15)
            {
                Check14.Content = "Верно";
                Check14.Foreground = Brushes.Black;
                Check14.Background = Brushes.LightGreen;
                task23_2.Background = Brushes.LightGreen;
            }
            else
            {
                Check14.Content = "не верно";
                Check14.Background = Brushes.Red;
                task23_2.Background = Brushes.Red;
            }
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
            task24.Visibility = Visibility.Visible;
            task24_1.Visibility = Visibility.Visible;
            task24_2.Visibility = Visibility.Visible;
            Check15.Visibility = Visibility.Visible;
        }

        private void Check15_Click(object sender, RoutedEventArgs e)
        {
            int a24;
            int.TryParse(task24_2.Text, out a24);
            if (a24 >= 1000 && a24 <= 9999 && a24 != 4999)
            {
                Check15.Content = "Верно";
                Check15.Foreground = Brushes.Black;
                Check15.Background = Brushes.LightGreen;
                task24_2.Background = Brushes.LightGreen;
            }
            else
            {
                Check15.Content = "не верно";
                Check15.Background = Brushes.Red;
                task24_2.Background = Brushes.Red;
            }
        }

        private void btn26_Click(object sender, RoutedEventArgs e)
        {
            Check16.Visibility = Visibility.Visible;
            task26.Visibility = Visibility.Visible;
            task26_1.Visibility = Visibility.Visible;
            task26_2.Visibility = Visibility.Visible;
            task26_3.Visibility = Visibility.Visible;
            task26_4.Visibility = Visibility.Visible;
        }

        private void Check16_Click(object sender, RoutedEventArgs e)
        {
            int x26, y26;
            int.TryParse(task26_2.Text, out x26);
            int.TryParse(task26_4.Text, out y26);

            bool result = ((x26 > 0 && x26 < 5) && (0 < y26 && y26 <= 6 && y26 < 7));
            if (result)
            {
                Check16.Content = "Верно";
                Check16.Foreground = Brushes.Black;
                Check16.Background = Brushes.LightGreen;
            }
            else
            {
                Check16.Content = "не верно";
                Check16.Background = Brushes.Red;
            }
        }

        private void btn27_Click(object sender, RoutedEventArgs e)
        {
            Check17.Visibility = Visibility.Visible;
            task27.Visibility = Visibility.Visible;
            task27_1.Visibility = Visibility.Visible;
            task27_2.Visibility = Visibility.Visible;
            task27_3.Visibility = Visibility.Visible;
            task27_4.Visibility = Visibility.Visible;


        }

        private void Check17_Click(object sender, RoutedEventArgs e)
        {

                int x27, y27;
                int.TryParse(task27_2.Text, out x27);
                int.TryParse(task27_4.Text, out y27);

                bool result = ((x27 > 3 || x27 < -1) && (-4 < y27 && y27 <= 2 && y27 > 0));
                if (result)
                {
                    Check17.Content = "Верно";
                    Check17.Foreground = Brushes.Black;
                    Check17.Background = Brushes.LightGreen;
                }
                else
                {
                    Check17.Content = "не верно";
                    Check17.Background = Brushes.Red;
                }
            }

        private void btn30_Click(object sender, RoutedEventArgs e)
        {
            task30.Visibility = Visibility.Visible;
            task30_1.Visibility = Visibility.Visible;
            task30_2.Visibility = Visibility.Visible;
            task30_3.Visibility = Visibility.Visible;
            task30_4.Visibility = Visibility.Visible;
            Check30.Visibility = Visibility.Visible;
        
        }

        private void Check30_Click(object sender, RoutedEventArgs e)
        {
 
            int x30, y30;
            int.TryParse(task30_2.Text, out x30);
            int.TryParse(task30_4.Text, out y30);

            bool isY1Defined = true;
            bool isY2Defined = true;


            double expression1 = 1 - Math.Cos(3 * x30);
            if (double.IsNaN(expression1) || double.IsInfinity(expression1))
            {
                isY1Defined = false;
            }

            double expression2 = y30 / Math.Pow(y30 - 3, 2);
            if (double.IsNaN(expression2) || double.IsInfinity(expression2))
            {
                isY2Defined = false;
            }


            if (isY1Defined)
            {

                task30_2.Background = Brushes.LightGreen;
                Check30.Content = "Верно";
                Check30.Foreground = Brushes.Black;
                Check30.Background = Brushes.LightGreen;

            }
            else
            {
                task30_2.Background = Brushes.Red;
                Check30.Content = "не верно";
                Check30.Background = Brushes.Red;
            }

            if (isY2Defined)
            {
                task20_4.Background = Brushes.LightGreen;
                Check12.Content = "Верно";
                Check12.Foreground = Brushes.Black;
                Check12.Background = Brushes.LightGreen;
            }
            else
            {

                task20_4.Background = Brushes.Red;
                Check12.Content = "не верно";
                Check12.Background = Brushes.Red;
            }
        }

        private void btn28_Click(object sender, RoutedEventArgs e)
        {
            task28.Visibility = Visibility.Visible;
            task28_1.Visibility = Visibility.Visible;
            task28_2.Visibility = Visibility.Visible;
            Check28.Visibility = Visibility.Visible;
        }

        private void Check28_Click(object sender, RoutedEventArgs e)
        {
            int x28;
            int.TryParse(task28_2.Text, out x28);


            bool isY1Defined = true;


            double expression1 = 1 / Math.Pow(x28-3, 2);
            if (double.IsNaN(expression1) || double.IsInfinity(expression1))
            {
                isY1Defined = false;
            }
            if (isY1Defined)
            {

                task28_2.Background = Brushes.LightGreen;
                Check28.Content = "Верно";
                Check28.Foreground = Brushes.Black;
                Check28.Background = Brushes.LightGreen;

            }
            else
            {
                task28_2.Background = Brushes.Red;
                Check28.Content = "не верно";
                Check28.Background = Brushes.Red;
            }
        }

        private void btn29_Click(object sender, RoutedEventArgs e)
        {
            task29.Visibility = Visibility.Visible;
            task29_1.Visibility = Visibility.Visible;
            task29_2.Visibility = Visibility.Visible;
            Check29.Visibility = Visibility.Visible;
        }

        private void Check29_Click(object sender, RoutedEventArgs e)
        {
            int x29;
            int.TryParse(task29_2.Text, out x29);


            bool isY1Defined = true;


            double expression1 = 1 / Math.Tanh(2)*x29;
            if (double.IsNaN(expression1) || double.IsInfinity(expression1))
            {
                isY1Defined = false;
            }
            if (isY1Defined)
            {

                task29_2.Background = Brushes.LightGreen;
                Check29.Content = "Верно";
                Check29.Foreground = Brushes.Black;
                Check29.Background = Brushes.LightGreen;

            }
            else
            {
                task29_2.Background = Brushes.Red;
                Check29.Content = "не верно";
                Check29.Background = Brushes.Red;
            }
        }

        private void btn31_Click(object sender, RoutedEventArgs e)
        {
           task31.Visibility = Visibility.Visible;
           task31_1.Visibility = Visibility.Visible;
           task31_2.Visibility = Visibility.Visible;
           task31_3.Visibility = Visibility.Visible;
           task31_4.Visibility = Visibility.Visible;
           task31_5.Visibility = Visibility.Visible;
           task31_6.Visibility = Visibility.Visible;
           task31_7.Visibility = Visibility.Visible;
           task31_8.Visibility = Visibility.Visible;
           task31_9.Visibility = Visibility.Visible;
           task31_10.Visibility = Visibility.Visible;
           task31_11.Visibility = Visibility.Visible;
           task31_12.Visibility = Visibility.Visible;
           Check31.Visibility = Visibility.Visible;
        }

        private void Check31_Click(object sender, RoutedEventArgs e)
        {


            int a31_1, b31_1, c31_1, a31, b31;
            bool alpha, beta;

            int.TryParse(task31_4.Text, out a31);
            int.TryParse(task31_5.Text, out b31);

            int.TryParse(task31_10.Text, out a31_1);
            int.TryParse(task31_11.Text, out b31_1);
            int.TryParse(task31_12.Text, out c31_1);



            if (a31 % 2 == 0 || b31 % 2 == 0)
            {
                

             
             Check31.Content = "Верно";
             Check31.Foreground = Brushes.Black;
             Check31.Background = Brushes.LightGreen;

            }
            else
            {
             Check31.Content = "не верно";
             Check31.Background = Brushes.Red;
            }
            

            if (a31_1 % 3 == 0 && b31_1 % 3 == 0 && c31_1 % 3 == 0)
            {
             Check31.Content = "Верно";
             Check31.Foreground = Brushes.Black;
             Check31.Background = Brushes.LightGreen;

            }
            else
            {
             Check31.Content = "не верно";
             Check31.Background = Brushes.Red;
            }

        }

        private void btn25_Click(object sender, RoutedEventArgs e)
        {
            task25.Visibility = Visibility.Visible;
            task25_1.Visibility = Visibility.Visible;
            task25_2.Visibility = Visibility.Visible;
            task25_3.Visibility = Visibility.Visible;
            task25_4.Visibility = Visibility.Visible;
            task25_5.Visibility = Visibility.Visible;
            task25_6.Visibility = Visibility.Visible;
            task25_7.Visibility = Visibility.Visible;
            task25_8.Visibility = Visibility.Visible;
            task25_9.Visibility = Visibility.Visible;
            task25_10.Visibility = Visibility.Visible;
            Check25.Visibility = Visibility.Visible;
        }

        private void Check25_Click(object sender, RoutedEventArgs e)
        {
            int A25, B25, C25, D25;
            int.TryParse(task25_3.Text, out A25);
            int.TryParse(task25_4.Text, out B25);
            int.TryParse(task25_7.Text, out C25);
            int.TryParse(task25_8.Text, out D25);

            if ((A25 / B25) > (C25 / D25))
            {

                Check25.Content = ">";


            }
            else if ((A25 / B25) < (C25 / D25))
            {
                Check25.Content = "<";
            }
            else
            {
                Check25.Content = "=";
            }
        }

        private DispatcherTimer timer;
        private int countdown = 300;
        private bool timerRunning = false;

        private void btn34_Click(object sender, RoutedEventArgs e)
        {
            if (!timerRunning)
            {
                task34.Visibility = Visibility.Visible;
                TimerTextBlock.Visibility = Visibility.Visible;
                InitializeComponent();

                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();

                timerRunning = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            TimerTextBlock.Text = $"времени прошло: {countdown / 60} мин {countdown % 60} сек";

            if (countdown == 0)
            {
                TimerTextBlock.Visibility = Visibility.Hidden;
                task34_1.Visibility = Visibility.Visible;

                timerRunning = false;
            }
        }

        private void btn32_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn33_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn35_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn36_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn37_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn38_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn39_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn40_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn41_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn42_Click(object sender, RoutedEventArgs e)
        {
            task0.Visibility = Visibility.Visible;
        }

        private void btn43_Click(object sender, RoutedEventArgs e)
        {
            task43.Visibility = Visibility.Visible;
            dkit.Visibility = Visibility.Visible;
            dpk.Visibility = Visibility.Visible;
        }

        private void dkit_Click(object sender, RoutedEventArgs e)
        {
            horosh.Visibility = Visibility.Visible;
        }

        private void dpk_Click(object sender, RoutedEventArgs e)
        {
            otchis.Visibility = Visibility.Visible;
        }

        private void riba_Click(object sender, RoutedEventArgs e)
        {
            chipi.Visibility = Visibility.Visible;
        }

        private void myaso_Click(object sender, RoutedEventArgs e)
        {
            chapa.Visibility = Visibility.Visible;
        }

        private void top_Click(object sender, RoutedEventArgs e)
        {
            verno.Visibility = Visibility.Visible;
        }

        private void luchiy_Click(object sender, RoutedEventArgs e)
        {
            verno.Visibility = Visibility.Visible;
        }

        private void btn45_Click(object sender, RoutedEventArgs e)
        {
            task45.Visibility = Visibility.Visible;
            top.Visibility = Visibility.Visible;
            luchiy.Visibility = Visibility.Visible;
        }

        private void btn44_Click(object sender, RoutedEventArgs e)
        {
            task44.Visibility = Visibility.Visible;
            riba.Visibility = Visibility.Visible;
            myaso.Visibility = Visibility.Visible;
        }
    }

}
