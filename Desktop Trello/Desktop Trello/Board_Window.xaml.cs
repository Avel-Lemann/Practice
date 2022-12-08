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

namespace Desktop_Trello
{
    /// <summary>
    /// Логика взаимодействия для Board_Window.xaml
    /// </summary>
    public partial class Board_Window : Window
    {
        public Board_Window()
        {
            InitializeComponent();
        }

        private void NewList_Click(object sender, RoutedEventArgs e)
        {
            GroupBox col = new GroupBox();
            Board_Window_Grid.Children.Add(col);
            col.PointToScreen(new Point(col.ActualWidth, col.ActualHeight));
            col.Style = (Style)Application.Current.FindResource("NewCard");


        }

        private void Favourite_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
