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
  
    public partial class Board_Window : Window
    {
        public int ListQuantity;
        public string List1Name;
        public string List2Name;
        public string List3Name;
        public Board_Window()
        {
            InitializeComponent();
        }

        private void NewList_Click(object sender, RoutedEventArgs e)
        {
            if(ListQuantity <= 2)
            {
                if(ListQuantity == 0)
                {
                    Column1.Visibility = Visibility.Visible;
                    Column1.Header = ListName.Text;
                    List1Name = ListName.Text;
                    ListQuantity++;
                    ListName.Text = "Название";
                    return;
                }

                if (ListQuantity == 1)
                {
                    if(ListName.Text != List1Name)
                    {
                        Column2.Visibility = Visibility.Visible;
                        Column2.Header = ListName.Text;
                        List2Name = ListName.Text;
                        ListQuantity++;
                        return;
                    }
                    else
                    { 
                        if (MessageBox.Show("Название нового списка совпадает с уже созданым", "Предупреждение", MessageBoxButton.OKCancel,MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            Column2.Visibility = Visibility.Visible;
                            Column2.Header = ListName.Text;
                            ListQuantity++;
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }

                if (ListQuantity == 2)
                {
                    if (ListName.Text != List1Name && ListName.Text != List2Name)
                    {
                        Column3.Visibility = Visibility.Visible;
                        Column3.Header = ListName.Text;
                        List3Name = ListName.Text;
                        ListQuantity++;
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Название нового списка совпадает с уже созданым", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            Column3.Visibility = Visibility.Visible;
                            Column3.Header = ListName.Text;
                            List3Name = ListName.Text;
                            ListQuantity++;
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("К сожалению приложение в текущий момент поддерживает только три списка. Приносим свои извенения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
        }

        private void Favourite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewCard_Click1(object sender, RoutedEventArgs e)
        {
            Column1.
        }
    }
}
