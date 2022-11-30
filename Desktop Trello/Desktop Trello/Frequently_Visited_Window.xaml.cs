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
        public Frequently_Visited_Window()
        {
            InitializeComponent();
        }

        private void Freq_Visit_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.freq_Visit = null;
        }
    }
}
