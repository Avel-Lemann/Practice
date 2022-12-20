using System;
using System.Collections.Generic;
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
  
    public partial class Board_Window : Window
    {

        public int ListQuantity;

        public int QuantityCardsList1;
        public int QuantityCardsList2;
        public int QuantityCardsList3;

        public string List1Name;
        public string List2Name;
        public string List3Name;

        public bool BoardFovarites = false;


        public Board_Window()
        {
            InitializeComponent();
            if(Properties.Settings.Default.CurrentUploadNumberBoard != 0)
            {
                UploadData();
            }
        }


        public void UploadData()
        {
            if(Properties.Settings.Default.CurrentUploadNumberBoard == 1)
            {
                if(Properties.Settings.Default.Board1ListQuantity == 3)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board1List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board1List2Name;

                    List3.Visibility = Visibility.Visible;
                    Header3.Text = Properties.Settings.Default.Board1List3Name;
                }
                else if(Properties.Settings.Default.Board1ListQuantity == 2)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board1List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board1List2Name;

                }
                else if (Properties.Settings.Default.Board1ListQuantity == 1)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board1List1Name;

                }
                //Выгрузка листа 1
                if (Properties.Settings.Default.Board1List1CardQuantity == 3)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board1List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board1List1Card2Text;

                    List1Card3.Visibility = Visibility.Visible;
                    List1Card3Text.Text = Properties.Settings.Default.Board1List1Card3Text;
                }
                else if (Properties.Settings.Default.Board1List1CardQuantity == 2)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board1List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board1List1Card2Text;
                }
                else if (Properties.Settings.Default.Board1List1CardQuantity == 1)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board1List1Card1Text;
                }
                //Выгрузка листа 2
                if (Properties.Settings.Default.Board1List2CardQuantity == 3)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board1List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board1List2Card2Text;

                    List2Card3.Visibility = Visibility.Visible;
                    List2Card3Text.Text = Properties.Settings.Default.Board1List2Card3Text;
                }
                else if (Properties.Settings.Default.Board1List2CardQuantity == 2)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board1List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board1List2Card2Text;
                }
                else if (Properties.Settings.Default.Board1List2CardQuantity == 1)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board1List2Card1Text;
                }
                //Выгрузка листа 3 
                if (Properties.Settings.Default.Board1List3CardQuantity == 3)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board1List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board1List3Card2Text;

                    List3Card3.Visibility = Visibility.Visible;
                    List3Card3Text.Text = Properties.Settings.Default.Board1List3Card3Text;
                }
                else if (Properties.Settings.Default.Board1List3CardQuantity == 2)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board1List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board1List3Card2Text;
                }
                else if (Properties.Settings.Default.Board1List3CardQuantity == 1)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board1List3Card1Text;
                }

                if (Properties.Settings.Default.Board1Favorites == true)
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                else
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));

                ImageBrush BackgroundBoardBrush = new ImageBrush();

                if (Properties.Settings.Default.BackgroundNumber1 == 1)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber1 == 2)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon4.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber1 == 3)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute));
                }
                else if(Properties.Settings.Default.BackgroundNumber1 == 0)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
                }

                BoardFovarites = Properties.Settings.Default.Board1Favorites;
                ListQuantity = Properties.Settings.Default.Board1ListQuantity;

                List1Name = Properties.Settings.Default.Board1List1Name;
                List2Name = Properties.Settings.Default.Board1List2Name;
                List3Name = Properties.Settings.Default.Board1List3Name;

                QuantityCardsList1 = Properties.Settings.Default.Board1List1CardQuantity;
                QuantityCardsList2 = Properties.Settings.Default.Board1List2CardQuantity;
                QuantityCardsList3 = Properties.Settings.Default.Board1List3CardQuantity;
                Background = BackgroundBoardBrush;

                Properties.Settings.Default.FrequentAttendanceBoard1++;
                Properties.Settings.Default.FrequentAttendanceBoard2--;
                Properties.Settings.Default.FrequentAttendanceBoard3--;

                return;
            }
            else if(Properties.Settings.Default.CurrentUploadNumberBoard == 2)
            {
                if (Properties.Settings.Default.Board2ListQuantity == 3)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board2List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board2List2Name;

                    List3.Visibility = Visibility.Visible;
                    Header3.Text = Properties.Settings.Default.Board2List3Name;
                }
                else if (Properties.Settings.Default.Board2ListQuantity == 2)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board2List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board2List2Name;
                }
                else if (Properties.Settings.Default.Board2ListQuantity == 1)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board2List1Name;
                }
                //Выгрузка листа 1
                if (Properties.Settings.Default.Board2List2CardQuantity == 3)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board2List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board2List1Card2Text;

                    List1Card3.Visibility = Visibility.Visible;
                    List1Card3Text.Text = Properties.Settings.Default.Board2List1Card3Text;
                }
                else if (Properties.Settings.Default.Board2List1CardQuantity == 2)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board2List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board2List1Card2Text;
                }
                else if (Properties.Settings.Default.Board2List1CardQuantity == 1)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board2List1Card1Text;
                }
                //Выгрузка листа 2
                if (Properties.Settings.Default.Board2List2CardQuantity == 3)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board2List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board2List2Card2Text;

                    List2Card3.Visibility = Visibility.Visible;
                    List2Card3Text.Text = Properties.Settings.Default.Board2List2Card3Text;
                }
                else if (Properties.Settings.Default.Board2List2CardQuantity == 2)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board2List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board2List2Card2Text;
                }
                else if (Properties.Settings.Default.Board2List2CardQuantity == 1)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board2List2Card1Text;
                }
                //Выгрузка листа 3 
                if (Properties.Settings.Default.Board2List2CardQuantity == 3)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board2List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board2List3Card2Text;

                    List3Card3.Visibility = Visibility.Visible;
                    List3Card3Text.Text = Properties.Settings.Default.Board2List3Card3Text;
                }
                else if (Properties.Settings.Default.Board2List3CardQuantity == 2)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board2List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board2List3Card2Text;
                }
                else if (Properties.Settings.Default.Board2List3CardQuantity == 1)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board2List3Card1Text;
                }

                if (Properties.Settings.Default.Board2Favorites == true)
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                else
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));

                ImageBrush BackgroundBoardBrush = new ImageBrush();

                if (Properties.Settings.Default.BackgroundNumber2 == 1)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber2 == 2)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon4.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber2 == 3)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute));
                }

                ListQuantity = Properties.Settings.Default.Board1ListQuantity;

                List1Name = Properties.Settings.Default.Board2List1Name;
                List2Name = Properties.Settings.Default.Board2List2Name;
                List3Name = Properties.Settings.Default.Board2List3Name;

                QuantityCardsList1 = Properties.Settings.Default.Board2List1CardQuantity;
                QuantityCardsList2 = Properties.Settings.Default.Board2List2CardQuantity;
                QuantityCardsList3 = Properties.Settings.Default.Board2List3CardQuantity;

                Background = BackgroundBoardBrush;

                Properties.Settings.Default.FrequentAttendanceBoard1--;
                Properties.Settings.Default.FrequentAttendanceBoard2++;
                Properties.Settings.Default.FrequentAttendanceBoard3--;

                return;
            }
            else if(Properties.Settings.Default.CurrentUploadNumberBoard == 3)
            {
                if (Properties.Settings.Default.Board3ListQuantity == 3)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board3List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board3List2Name;

                    List3.Visibility = Visibility.Visible;
                    Header3.Text = Properties.Settings.Default.Board3List3Name;
                }
                else if (Properties.Settings.Default.Board3ListQuantity == 2)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board3List1Name;

                    List2.Visibility = Visibility.Visible;
                    Header2.Text = Properties.Settings.Default.Board3List2Name;
                }
                else if (Properties.Settings.Default.Board3ListQuantity == 1)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = Properties.Settings.Default.Board3List1Name;
                }
                //Выгрузка листа 1
                if (Properties.Settings.Default.Board3List1CardQuantity == 3)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board3List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board3List1Card2Text;

                    List1Card3.Visibility = Visibility.Visible;
                    List1Card3Text.Text = Properties.Settings.Default.Board3List1Card3Text;
                }
                else if (Properties.Settings.Default.Board3List1CardQuantity == 2)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board3List1Card1Text;

                    List1Card2.Visibility = Visibility.Visible;
                    List1Card2Text.Text = Properties.Settings.Default.Board3List1Card2Text;
                }
                else if (Properties.Settings.Default.Board3List1CardQuantity == 1)
                {
                    List1Card1.Visibility = Visibility.Visible;
                    List1Card1Text.Text = Properties.Settings.Default.Board3List1Card1Text;
                }
                //Выгрузка листа 2
                if (Properties.Settings.Default.Board3List2CardQuantity == 3)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board3List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board3List2Card2Text;

                    List2Card3.Visibility = Visibility.Visible;
                    List2Card3Text.Text = Properties.Settings.Default.Board3List2Card3Text;
                }
                else if (Properties.Settings.Default.Board3List2CardQuantity == 2)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board3List2Card1Text;

                    List2Card2.Visibility = Visibility.Visible;
                    List2Card2Text.Text = Properties.Settings.Default.Board3List2Card2Text;
                }
                else if (Properties.Settings.Default.Board3List2CardQuantity == 1)
                {
                    List2Card1.Visibility = Visibility.Visible;
                    List2Card1Text.Text = Properties.Settings.Default.Board3List2Card1Text;
                }
                //Выгрузка листа 3 
                if (Properties.Settings.Default.Board3List3CardQuantity == 3)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board3List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board3List3Card2Text;

                    List3Card3.Visibility = Visibility.Visible;
                    List3Card3Text.Text = Properties.Settings.Default.Board3List3Card3Text;
                }
                else if (Properties.Settings.Default.Board3List3CardQuantity == 2)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board3List3Card1Text;

                    List3Card2.Visibility = Visibility.Visible;
                    List3Card2Text.Text = Properties.Settings.Default.Board3List3Card2Text;
                }
                else if (Properties.Settings.Default.Board3List3CardQuantity == 1)
                {
                    List3Card1.Visibility = Visibility.Visible;
                    List3Card1Text.Text = Properties.Settings.Default.Board3List3Card1Text;
                }

                if (Properties.Settings.Default.Board3Favorites == true)
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                else
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));

                ImageBrush BackgroundBoardBrush = new ImageBrush();

                if (Properties.Settings.Default.BackgroundNumber3 == 1)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon1.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber3 == 2)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon4.png", UriKind.Absolute));
                }
                else if (Properties.Settings.Default.BackgroundNumber3 == 3)
                {
                    BackgroundBoardBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Fon3.png", UriKind.Absolute));
                }

                ListQuantity = Properties.Settings.Default.Board3ListQuantity;

                List1Name = Properties.Settings.Default.Board3List1Name;
                List2Name = Properties.Settings.Default.Board3List2Name;
                List3Name = Properties.Settings.Default.Board3List3Name;

                QuantityCardsList1 = Properties.Settings.Default.Board3List1CardQuantity;
                QuantityCardsList2 = Properties.Settings.Default.Board3List2CardQuantity;
                QuantityCardsList3 = Properties.Settings.Default.Board3List3CardQuantity;
                Background = BackgroundBoardBrush;

                Properties.Settings.Default.FrequentAttendanceBoard1--;
                Properties.Settings.Default.FrequentAttendanceBoard2--;
                Properties.Settings.Default.FrequentAttendanceBoard3++;

                return;
            }
        }

        public void SaveData()
        {
            if (Title == Properties.Settings.Default.BoardName1 || (Properties.Settings.Default.CurrentUploadNumberBoard == 0 && Properties.Settings.Default.BoardName2 == ""))
            {
                Properties.Settings.Default.Board1ListQuantity = ListQuantity;

                Properties.Settings.Default.Board1List1CardQuantity = QuantityCardsList1;
                Properties.Settings.Default.Board1List2CardQuantity = QuantityCardsList2;
                Properties.Settings.Default.Board1List3CardQuantity = QuantityCardsList3;

                Properties.Settings.Default.Board1List1Name = Header1.Text;
                Properties.Settings.Default.Board1List2Name = Header2.Text;
                Properties.Settings.Default.Board1List3Name = Header3.Text;

                Properties.Settings.Default.Board1List1Card1Text = List1Card1Text.Text;
                Properties.Settings.Default.Board1List1Card2Text = List1Card2Text.Text;
                Properties.Settings.Default.Board1List1Card3Text = List1Card3Text.Text;
                Properties.Settings.Default.Board1List2Card1Text = List2Card1Text.Text;
                Properties.Settings.Default.Board1List2Card2Text = List2Card2Text.Text;
                Properties.Settings.Default.Board1List2Card3Text = List2Card3Text.Text;
                Properties.Settings.Default.Board1List3Card1Text = List3Card1Text.Text;
                Properties.Settings.Default.Board1List3Card2Text = List3Card2Text.Text;
                Properties.Settings.Default.Board1List3Card3Text = List3Card3Text.Text;
                Properties.Settings.Default.CurrentUploadNumberBoard = 0;
                Properties.Settings.Default.Save();
            }
            else if (Title == Properties.Settings.Default.BoardName2 || (Properties.Settings.Default.CurrentUploadNumberBoard == 0 && Properties.Settings.Default.BoardName2 == ""))
            {
                Properties.Settings.Default.Board2ListQuantity = ListQuantity;

                Properties.Settings.Default.Board2List1CardQuantity = QuantityCardsList1;
                Properties.Settings.Default.Board2List2CardQuantity = QuantityCardsList2;
                Properties.Settings.Default.Board2List3CardQuantity = QuantityCardsList3;

                Properties.Settings.Default.Board2List1Name = Header1.Text;
                Properties.Settings.Default.Board2List2Name = Header2.Text;
                Properties.Settings.Default.Board2List3Name = Header3.Text;

                Properties.Settings.Default.Board2List1Card1Text = List1Card1Text.Text;
                Properties.Settings.Default.Board2List1Card2Text = List1Card2Text.Text;
                Properties.Settings.Default.Board2List1Card3Text = List1Card3Text.Text;
                Properties.Settings.Default.Board2List2Card1Text = List2Card1Text.Text;
                Properties.Settings.Default.Board2List2Card2Text = List2Card2Text.Text;
                Properties.Settings.Default.Board2List2Card3Text = List2Card3Text.Text;
                Properties.Settings.Default.Board2List3Card1Text = List3Card1Text.Text;
                Properties.Settings.Default.Board2List3Card2Text = List3Card2Text.Text;
                Properties.Settings.Default.Board2List3Card3Text = List3Card3Text.Text;
                Properties.Settings.Default.CurrentUploadNumberBoard = 0;
                Properties.Settings.Default.Save();
            }
            else if (Title == Properties.Settings.Default.BoardName3)
            {
                Properties.Settings.Default.Board3ListQuantity = ListQuantity;

                Properties.Settings.Default.Board3List1CardQuantity = QuantityCardsList1;
                Properties.Settings.Default.Board3List2CardQuantity = QuantityCardsList2;
                Properties.Settings.Default.Board3List3CardQuantity = QuantityCardsList3;

                Properties.Settings.Default.Board3List1Name = Header1.Text;
                Properties.Settings.Default.Board3List2Name = Header2.Text;
                Properties.Settings.Default.Board3List3Name = Header3.Text;

                Properties.Settings.Default.Board3List1Card1Text = List1Card1Text.Text;
                Properties.Settings.Default.Board3List1Card2Text = List1Card2Text.Text;
                Properties.Settings.Default.Board3List1Card3Text = List1Card3Text.Text;
                Properties.Settings.Default.Board3List2Card1Text = List2Card1Text.Text;
                Properties.Settings.Default.Board3List2Card2Text = List2Card2Text.Text;
                Properties.Settings.Default.Board3List2Card3Text = List2Card3Text.Text;
                Properties.Settings.Default.Board3List3Card1Text = List3Card1Text.Text;
                Properties.Settings.Default.Board3List3Card2Text = List3Card2Text.Text;
                Properties.Settings.Default.Board3List3Card3Text = List3Card3Text.Text;
                Properties.Settings.Default.CurrentUploadNumberBoard = 0;
                Properties.Settings.Default.Save();
            }

        }





        private void BoardWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы собираетесь закрыть доску. Сохранить изменения?", "Предупреждение", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                SaveData();
                MainWindow main = new MainWindow();
                main.Show();
                main = null;
                Properties.Settings.Default.CurrentUploadNumberBoard = 0;
                e.Cancel = false;
            }
            else if(result == MessageBoxResult.No)
            {
                MainWindow main = new MainWindow();
                main.Show();
                main = null;
                Properties.Settings.Default.CurrentUploadNumberBoard = 0;
                e.Cancel = false;
            }
            else if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

       

        private void NewList_Click(object sender, RoutedEventArgs e)
        {

            if(ListQuantity <= 2)
            {
                if(ListQuantity == 0)
                {
                    List1.Visibility = Visibility.Visible;
                    Header1.Text = ListName.Text;
                    List1Name = ListName.Text;
                    ListQuantity++;
                    ListName.Text = "Название";
                    return;
                }

                if (ListQuantity == 1)
                {
                    if (ListName.Text != List1Name)
                    {
                        List2.Visibility = Visibility.Visible;
                        Header2.Text = ListName.Text;
                        List2Name = ListName.Text;
                        ListQuantity++;
                        return;
                    }
                    else if (ListName.Text == List1Name) 
                    { 
                        if (MessageBox.Show("Название нового списка совпадает с уже созданым", "Предупреждение", MessageBoxButton.OKCancel,MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            List2.Visibility = Visibility.Visible;
                            Header2.Text = ListName.Text;
                            List2Name = ListName.Text;
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
                        List3.Visibility = Visibility.Visible;
                        Header3.Text = ListName.Text;
                        List3Name = ListName.Text;
                        ListQuantity++;
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Название нового списка совпадает с уже созданым", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            List3.Visibility = Visibility.Visible;
                            Header3.Text = ListName.Text;
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


        
            //
            //          ПЕРВЫЙ ЛИСТ
            //          СОЗДАНИЕ КАРТОЧЕК
            //



        private void NewCard1_Click(object sender, RoutedEventArgs e)
        {
            if (List1Card1.Visibility != Visibility.Visible)
            {
                QuantityCardsList1++;
                List1Card1.Visibility = Visibility.Visible;
                return;

            }
            else if (List1Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList1++;
                List1Card2.Visibility = Visibility.Visible;
                return;
            }
            else if (List1Card3.Visibility != Visibility.Visible)
            {
                QuantityCardsList1++;
                List1Card3.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                MessageBox.Show("К сожалению приложение в текущий момент поддерживает только три карточки в одном списке. Приносим свои извенения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        //
        //          ПЕРВЫЙ ЛИСТ
        //          УДАЛЕНИЕ КАРТОЧЕК
        //

        private void DeleteList1Card1_Click(object sender, RoutedEventArgs e)
        {
            if (List1Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList1--;
                List1Card1Text.Text = List1Card2Text.Text;
                List1Card2Text.Text = List1Card3Text.Text;
                List1Card3.Visibility = Visibility.Hidden;
                List1Card3Text.Text = "";
            }
            else if (List1Card2.Visibility == Visibility.Visible)
            {
                QuantityCardsList1--;
                List1Card1Text.Text = List1Card2Text.Text;
                List1Card2.Visibility = Visibility.Hidden;
                List1Card2Text.Text = "";
            }
            else if (List1Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList1--;
                List1Card1.Visibility = Visibility.Hidden;
                List1Card1Text.Text = "";
            }
        }

        private void DeleteList1Card2_Click(object sender, RoutedEventArgs e)
        {
            if(List1Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList1--;
                List1Card2Text.Text = List1Card3Text.Text;
                List1Card3.Visibility = Visibility.Hidden;
                List1Card3Text.Text = "";
            }
            else
            {
                QuantityCardsList1--;
                List1Card2.Visibility = Visibility.Hidden;
                List1Card2Text.Text = "";
            }
        }

        private void DeleteList1Card3_Click(object sender, RoutedEventArgs e)
        {
            QuantityCardsList1--;
            List1Card3.Visibility = Visibility.Hidden;
            List1Card3Text.Text = "";
        }

        //
        //          ВТОРОЙ ЛИСТ
        //          СОЗДАНИЕ КАРТОЧЕК
        //

        private void NewCard2_Click(object sender, RoutedEventArgs e)
        {
            if (List2Card1.Visibility != Visibility.Visible)
            {
                QuantityCardsList2++;
                List2Card1.Visibility = Visibility.Visible;
                return;

            }
            else if (List2Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList2++;
                List2Card2.Visibility = Visibility.Visible;
                return;
            }
            else if (List2Card3.Visibility != Visibility.Visible)
            {
                QuantityCardsList2++;
                List2Card3.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                MessageBox.Show("К сожалению приложение в текущий момент поддерживает только три карточки в одном списке. Приносим свои извенения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }


        //
        //          ВТОРОЙ ЛИСТ
        //          УДАЛЕНИЕ КАРТОЧЕК
        //

        private void DeleteList2Card1_Click(object sender, RoutedEventArgs e)
        {
            if (List2Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList2--;
                List2Card1Text.Text = List2Card2Text.Text;
                List2Card2Text.Text = List2Card3Text.Text;
                List2Card3.Visibility = Visibility.Hidden;
                List2Card3Text.Text = "";
            }
            else if (List2Card2.Visibility == Visibility.Visible)
            {
                QuantityCardsList2--;
                List2Card1Text.Text = List2Card2Text.Text;
                List2Card2.Visibility = Visibility.Hidden;
                List2Card2Text.Text = "";
            }
            else if (List2Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList2--;
                List2Card1.Visibility = Visibility.Hidden;
                List2Card1Text.Text = "";
            }
        }

        private void DeleteList2Card2_Click(object sender, RoutedEventArgs e)
        {
            if (List2Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList2--;
                List2Card2Text.Text = List2Card3Text.Text;
                List2Card3.Visibility = Visibility.Hidden;
                List2Card3Text.Text = "";
            }
            else
            {
                QuantityCardsList2--;
                List2Card2.Visibility = Visibility.Hidden;
                List2Card2Text.Text = "";
            }
        }

        private void DeleteList2Card3_Click(object sender, RoutedEventArgs e)
        {
            QuantityCardsList2--;
            List2Card3.Visibility = Visibility.Hidden;
            List2Card3Text.Text = "";
        }

        //
        //          ТРЕТИЙ ЛИСТ
        //          СОЗДАНИЕ КАРТОЧЕК
        //

        private void NewCard3_Click(object sender, RoutedEventArgs e)
        {
            if (List3Card1.Visibility != Visibility.Visible)
            {
                QuantityCardsList3++;
                List3Card1.Visibility = Visibility.Visible;
                return;

            }
            else if (List3Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList3++;
                List3Card2.Visibility = Visibility.Visible;
                return;
            }
            else if (List3Card3.Visibility != Visibility.Visible)
            {
                QuantityCardsList3++;
                List3Card3.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                MessageBox.Show("К сожалению приложение в текущий момент поддерживает только три карточки в одном списке. Приносим свои извенения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        //
        //          ТРЕТИЙ ЛИСТ
        //          УДАЛЕНИЕ КАРТОЧЕК
        //
        private void DeleteList3Card1_Click(object sender, RoutedEventArgs e)
        {
            if (List3Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList3--;
                List3Card1Text.Text = List3Card2Text.Text;
                List3Card2Text.Text = List3Card3Text.Text;
                List3Card3.Visibility = Visibility.Hidden;
                List3Card3Text.Text = "";
            }
            else if (List3Card2.Visibility == Visibility.Visible)
            {
                QuantityCardsList3--;
                List3Card1Text.Text = List3Card2Text.Text;
                List3Card2.Visibility = Visibility.Hidden;
                List3Card2Text.Text = "";
            }
            else if (List3Card2.Visibility != Visibility.Visible)
            {
                QuantityCardsList3--;
                List3Card1.Visibility = Visibility.Hidden;
                List3Card1Text.Text = "";
            }
        }

        private void DeleteList3Card2_Click(object sender, RoutedEventArgs e)
        {
            if (List3Card3.Visibility == Visibility.Visible)
            {
                QuantityCardsList3--;
                List3Card2Text.Text = List3Card3Text.Text;
                List3Card3.Visibility = Visibility.Hidden;
                List3Card3Text.Text = "";
            }
            else
            {
                QuantityCardsList3--;
                List3Card2.Visibility = Visibility.Hidden;
                List3Card2Text.Text = "";
            }
        }

        private void DeleteList3Card3_Click(object sender, RoutedEventArgs e)
        {
            QuantityCardsList3--;
            List3Card3.Visibility = Visibility.Hidden;
            List3Card3Text.Text = "";
        }

        private void Favourite_Click_1(object sender, RoutedEventArgs e)
        {
            if(Properties.Settings.Default.CurrentUploadNumberBoard == 1)
            {
                if (Properties.Settings.Default.Board1Favorites == true)
                {
                    Properties.Settings.Default.Board1Favorites = false;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber--;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Board1Favorites = true;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber++;
                    Properties.Settings.Default.Save();
                }
            }
            else if (Properties.Settings.Default.CurrentUploadNumberBoard == 2)
            {
                if (Properties.Settings.Default.Board2Favorites == true)
                {
                    Properties.Settings.Default.Board2Favorites = false;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber--;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Board2Favorites = true;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber++;
                    Properties.Settings.Default.Save();
                }
            }
            else if (Properties.Settings.Default.CurrentUploadNumberBoard == 3)
            {
                if (Properties.Settings.Default.Board3Favorites == true)
                {
                    Properties.Settings.Default.Board3Favorites = false;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_pustoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber--;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Board3Favorites = true;
                    FavBut.Source = (new BitmapImage(new Uri("pack://application:,,,/Resources/Serdechko_zapolnennoe.png", UriKind.Absolute)));
                    Properties.Settings.Default.FavoriteBoardNumber++;
                    Properties.Settings.Default.Save();
                }
            }
        }

        
    }
}
