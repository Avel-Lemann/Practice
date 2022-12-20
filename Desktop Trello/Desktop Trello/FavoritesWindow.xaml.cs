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

            if (Properties.Settings.Default.QuantityBoard == 2)
            {
                FavBoard1.Visibility = Visibility.Visible;
                FavBoard2.Visibility = Visibility.Visible;
                return;
            }
            else if (Properties.Settings.Default.QuantityBoard == 1)
            {
                FavBoard1.Visibility = Visibility.Visible;
                return;
            }
        }
        private void FavBoard1_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.CurrentUploadNumberBoard = 1;
            Board_Window = new Board_Window();
            Board_Window.Title = Properties.Settings.Default.BoardName1;
            Board_Window.Show();
            MainWindow.favorites = null;
            this.Owner.Close();
        }

        private void FavBoard2_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.CurrentUploadNumberBoard = 2;
            Board_Window = new Board_Window();
            Board_Window.Title = Properties.Settings.Default.BoardName1;
            Board_Window.Show();
            MainWindow.favorites = null;
            this.Owner.Close();
        }
    }
}
