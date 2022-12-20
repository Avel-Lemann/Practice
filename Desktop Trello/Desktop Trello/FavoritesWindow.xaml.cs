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
    /// Логика взаимодействия для FavoritesWindow.xaml
    /// </summary>
    public partial class FavoritesWindow : Window
    {
        public static Board_Window Board_Window;
        public FavoritesWindow()
        {
            InitializeComponent();
            Upload();
        }

        private void FavoritesWindow_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.favorites = null;
        }

        public void Upload()
        {
            

            FavBoard1.Content = Properties.Settings.Default.BoardName1;
            FavBoard2.Content = Properties.Settings.Default.BoardName2;

            if (Properties.Settings.Default.FavoriteBoardNumber == 1 || Properties.Settings.Default.FavoriteBoardNumber == 2)
            {
                FavBoard1.Visibility = Visibility.Visible;
                if(Properties.Settings.Default.Board1Favorites == true)
                {
                    FavBoard1.Content = Properties.Settings.Default.BoardName1;
                }
                else if (Properties.Settings.Default.Board2Favorites == true)
                {
                    FavBoard1.Content = Properties.Settings.Default.BoardName2;
                }
                else if (Properties.Settings.Default.Board3Favorites == true)
                {
                    FavBoard1.Content = Properties.Settings.Default.BoardName3;
                }
            }

            if (Properties.Settings.Default.FavoriteBoardNumber == 2)
            {
                FavBoard2.Visibility = Visibility.Visible;
                if (Properties.Settings.Default.Board2Favorites == true && Properties.Settings.Default.BoardName2 != FavBoard1.Content.ToString())
                {
                    FavBoard2.Content = Properties.Settings.Default.BoardName2;
                }
                else if (Properties.Settings.Default.Board3Favorites == true && Properties.Settings.Default.BoardName3 != FavBoard1.Content.ToString())
                {
                    FavBoard2.Content = Properties.Settings.Default.BoardName3;
                }
            }
        }
        private void FavBoard1_Click(object sender, RoutedEventArgs e)
        {
            
            if (FavBoard1.Content.ToString() == Properties.Settings.Default.BoardName1)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 1;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName1;
            }
            else if (FavBoard1.Content.ToString() == Properties.Settings.Default.BoardName2)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 2;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName2;
            }
            else if (FavBoard1.Content.ToString() == Properties.Settings.Default.BoardName3)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 3;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName3;
            }
            Board_Window.Show();
            MainWindow.favorites = null;
            this.Owner.Close();
        }

        private void FavBoard2_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (FavBoard2.Content.ToString() == Properties.Settings.Default.BoardName2)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 2;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName2;
            }
            else if (FavBoard2.Content.ToString() == Properties.Settings.Default.BoardName3)
            {
                Properties.Settings.Default.CurrentUploadNumberBoard = 3;
                Board_Window = new Board_Window();
                Board_Window.Title = Properties.Settings.Default.BoardName3;
            }
            Board_Window.Show();
            MainWindow.favorites = null;
            this.Owner.Close();
        }

    }
}
