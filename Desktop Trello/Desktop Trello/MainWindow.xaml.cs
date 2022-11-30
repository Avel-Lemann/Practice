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

namespace Desktop_Trello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Creation_Menu CrMenu;
        public static NotificationWindow notifications;
        public static FavoritesWindow favorites;
        public static Frequently_Visited_Window freq_Visit;
        public static Paschalka pasc;
        public static User user;
        public MainWindow()
        {
            InitializeComponent();
        }


        

        private void NewBoard_Click(object sender, RoutedEventArgs e)
        {
            

            if (CrMenu == null)
            {
                CrMenu = new Creation_Menu();
                CrMenu.ShowDialog();
            }
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            if (pasc == null)
            {
                pasc = new Paschalka();
                pasc.ShowDialog();
            }
            MessageBox.Show("Вы нашли Стаса", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Notifications_Click(object sender, RoutedEventArgs e)
        {
            if (notifications == null)
            {
                notifications = new NotificationWindow();
                notifications.Show();
            }
            else
            {
                notifications.Activate();
            }
        }

        private void Favorites_Click(object sender, RoutedEventArgs e)
        {
            if (favorites == null)
            {
                favorites = new FavoritesWindow();
                favorites.Show();
            }
            else
            {
                favorites.Activate();
            }
        }

        private void Frequently_Visited_Click(object sender, RoutedEventArgs e)
        {
            if (freq_Visit == null)
            {
                freq_Visit = new Frequently_Visited_Window();
                freq_Visit.Show();
            }
            else
            {
                freq_Visit.Activate();
            }
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                user = new User();
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }
    }
}
