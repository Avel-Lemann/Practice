﻿using System;
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
        public FavoritesWindow()
        {
            InitializeComponent();
        }

        private void FavoritesWindow_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.favorites = null;
        }

        private void FavBoard1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FavBoard2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
