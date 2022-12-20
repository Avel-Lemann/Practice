using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        public int QuantityBoard;

        

        public static Board_Window Board_Window;
        public static MainWindow MainWindow;

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
            NameBoard.Text.Trim();
            if ((!String.IsNullOrWhiteSpace(NameBoard.Text) && !(Properties.Settings.Default.QuantityBoard >= 3)))
            {
                if (NameBoard.Text.StartsWith(" "))
                {
                    MessageBox.Show("Строка не может начинатся с пробела.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    NameBoard.Text.Trim();
                    
                    

                    Board_Window board_Window = new Board_Window();
                    board_Window.Title = NameBoard.Text;
                    ImageBrush BackgroundBoardBrush = new ImageBrush();

                    if (Background_Number == 1)
                    {
                        BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
                    }
                    else if (Background_Number == 2)
                    {
                        BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon4.png", UriKind.Absolute));
                        
                    }
                    else if (Background_Number == 3)
                    {
                        BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute));
                        
                    }


                    if (Properties.Settings.Default.QuantityBoard == 0)
                    {
                        Properties.Settings.Default.BoardName1 = NameBoard.Text;
                        Properties.Settings.Default.BackgroundNumber1 = Background_Number;
                    }
                    else if (Properties.Settings.Default.QuantityBoard == 1)
                    {
                        Properties.Settings.Default.BoardName2 = NameBoard.Text;
                        Properties.Settings.Default.BackgroundNumber2 = Background_Number;
                    }
                    else if (Properties.Settings.Default.QuantityBoard == 2)
                    {
                        Properties.Settings.Default.BoardName3 = NameBoard.Text;
                        Properties.Settings.Default.BackgroundNumber3 = Background_Number;
                    }

                    Properties.Settings.Default.QuantityBoard++;
                    board_Window.Background = BackgroundBoardBrush;
                    board_Window.Show();
                    MainWindow.CrMenu = null;
                    this.Owner.Close();
                    
                }

               

            }
            else if(String.IsNullOrWhiteSpace(NameBoard.Text))
            {
                MessageBox.Show("Пожалуйста, введите название для доски.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if ((Properties.Settings.Default.QuantityBoard >= 3))
            {
                MessageBox.Show("К сожалению приложение в текущий момент поддерживает только три доски.Приносим свои извенения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
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
