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
    /// Логика взаимодействия для Creation_Menu.xaml
    /// </summary>
    public partial class Creation_Menu : Window
    {
        public int Background_Number = 1;
        public Creation_Menu()
        {
            InitializeComponent();
        }

        public void Creation_Menu_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.CrMenu = null;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            
            Board_Window board_Window = new Board_Window();
            board_Window.Title = NameBoard.Text;
            ImageBrush BackgroundBoardBrush = new ImageBrush();
            if(Background_Number == 1)
            {
                BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
            }
            if(Background_Number == 2)
            {
                BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon2.png", UriKind.Absolute));
            }
            if(Background_Number == 3)
            {
                BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute));
            }
            board_Window.Background = BackgroundBoardBrush;
            board_Window.ShowDialog();
        }

        private void Fon1_Click(object sender, RoutedEventArgs e)
        {
            Background_Number = 1;
            Preview.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute)));
        }

        private void Fon2_Click(object sender, RoutedEventArgs e)
        {
            Background_Number = 2;
            Preview.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Fon2.png", UriKind.Absolute)));
        }

        private void Fon3_Click(object sender, RoutedEventArgs e)
        {
            Background_Number = 3;
            Preview.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute)));
        }
    }
}
