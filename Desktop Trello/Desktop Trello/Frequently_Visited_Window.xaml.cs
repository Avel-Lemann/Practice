using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Desktop_Trello
{

    /// <summary>
    /// Логика взаимодействия для Frequently_Visited_Window.xaml
    /// </summary>
    public partial class Frequently_Visited_Window : Window
    {
        public static Board_Window Board_Window;
        public Frequently_Visited_Window()
        {
            InitializeComponent();
            Upload();
        }

        public void Upload()
        {
            if(Properties.Settings.Default.FrequentAttendanceBoard1 > 0)
            {
                Properties.Settings.Default.FrequentAttendanceBoard1 = 0;
            }

            if (Properties.Settings.Default.FrequentAttendanceBoard2 > 0)
            {
                Properties.Settings.Default.FrequentAttendanceBoard2 = 0;
            }

            if (Properties.Settings.Default.FrequentAttendanceBoard3 > 0)
            {
                Properties.Settings.Default.FrequentAttendanceBoard3 = 0;
            }

            if(Properties.Settings.Default.QuantityBoard == 1)
            {
                FrVisBoard1.Visibility = Visibility.Visible;
                FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
            }
            else if (Properties.Settings.Default.QuantityBoard == 2)
            {
                FrVisBoard1.Visibility = Visibility.Visible;
                FrVisBoard2.Visibility = Visibility.Visible;

                if(Properties.Settings.Default.FrequentAttendanceBoard1 > Properties.Settings.Default.FrequentAttendanceBoard2)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
                    FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                }
                else if(Properties.Settings.Default.FrequentAttendanceBoard1 < Properties.Settings.Default.FrequentAttendanceBoard2)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName2;
                    FrVisBoard2.Content = Properties.Settings.Default.BoardName1;
                }
                else if(Properties.Settings.Default.FrequentAttendanceBoard1 == Properties.Settings.Default.FrequentAttendanceBoard2)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
                    FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                }
            }
            else if (Properties.Settings.Default.QuantityBoard == 3)
            {
                FrVisBoard1.Visibility = Visibility.Visible;
                FrVisBoard2.Visibility = Visibility.Visible;

                if(Properties.Settings.Default.FrequentAttendanceBoard1 > Properties.Settings.Default.FrequentAttendanceBoard2 && Properties.Settings.Default.FrequentAttendanceBoard1 > Properties.Settings.Default.FrequentAttendanceBoard3)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
                    if(Properties.Settings.Default.FrequentAttendanceBoard2 > Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                    }
                    else if(Properties.Settings.Default.FrequentAttendanceBoard2 < Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName3;
                    }
                    else if(Properties.Settings.Default.FrequentAttendanceBoard2 == Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                    }
                }
                else if (Properties.Settings.Default.FrequentAttendanceBoard2 > Properties.Settings.Default.FrequentAttendanceBoard1 && Properties.Settings.Default.FrequentAttendanceBoard2 > Properties.Settings.Default.FrequentAttendanceBoard3)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName2;
                    if (Properties.Settings.Default.FrequentAttendanceBoard1 > Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName1;
                    }
                    else if (Properties.Settings.Default.FrequentAttendanceBoard1 < Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName3;
                    }
                    else if (Properties.Settings.Default.FrequentAttendanceBoard1 == Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName1;
                    }
                }
                else if (Properties.Settings.Default.FrequentAttendanceBoard3 > Properties.Settings.Default.FrequentAttendanceBoard1 && Properties.Settings.Default.FrequentAttendanceBoard3 > Properties.Settings.Default.FrequentAttendanceBoard2)
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName3;
                    if (Properties.Settings.Default.FrequentAttendanceBoard1 > Properties.Settings.Default.FrequentAttendanceBoard2)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName1;
                    }
                    else if (Properties.Settings.Default.FrequentAttendanceBoard1 < Properties.Settings.Default.FrequentAttendanceBoard2)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                    }
                    else if (Properties.Settings.Default.FrequentAttendanceBoard1 == Properties.Settings.Default.FrequentAttendanceBoard2)
                    {
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                    }
                    else if(Properties.Settings.Default.FrequentAttendanceBoard1 == Properties.Settings.Default.FrequentAttendanceBoard2 && Properties.Settings.Default.FrequentAttendanceBoard2 == Properties.Settings.Default.FrequentAttendanceBoard3)
                    {
                        FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
                        FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                    }
                }
                else
                {
                    FrVisBoard1.Content = Properties.Settings.Default.BoardName1;
                    FrVisBoard2.Content = Properties.Settings.Default.BoardName2;
                }
            }
        }

        private void Freq_Visit_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.freq_Visit = null;
        }

        private void FrVisBoard1_Click(object sender, RoutedEventArgs e)
        {
            if (FrVisBoard1.Content.ToString() == Properties.Settings.Default.BoardName1)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 1;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName1;
            }
            else if (FrVisBoard1.Content.ToString() == Properties.Settings.Default.BoardName2)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 2;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName2;
            }
            else if (FrVisBoard1.Content.ToString() == Properties.Settings.Default.BoardName3)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 3;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName3;
            }
            Board_Window.Show();
            MainWindow.freq_Visit = null;
            this.Owner.Close();
        }

        private void FrVisBoard2_Click(object sender, RoutedEventArgs e)
        {
            if (FrVisBoard2.Content.ToString() == Properties.Settings.Default.BoardName1)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 1;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName1;
            }
            else if (FrVisBoard2.Content.ToString() == Properties.Settings.Default.BoardName2)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 2;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName2;
            }
            else if (FrVisBoard2.Content.ToString() == Properties.Settings.Default.BoardName3)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 3;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName3;
            }
            Board_Window.Show();
            MainWindow.freq_Visit = null;
            this.Owner.Close();
        }
    }
}
