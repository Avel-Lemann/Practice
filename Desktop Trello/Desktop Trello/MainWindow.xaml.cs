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
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Frequently_Visited_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewBoard_Click(object sender, RoutedEventArgs e)
        {
            if (CrMenu == null)
            {
                CrMenu = new Creation_Menu();
                CrMenu.Show();
            }
            else CrMenu.Activate();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не тыкай!", "Чо ты тыкаешь?", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
