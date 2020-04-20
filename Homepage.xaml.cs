using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace SkipTheWaiterv3
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        List<Item> bill = new List<Item>();
        public Homepage()
        {
            InitializeComponent();
        }


        private void juiceClick(object sender, RoutedEventArgs e)
        {
            bill.Add(new Item("Orange Juice", 4.99));
            // Settings to generate a New Label
              Label item = new Label();
             item.Content = "Orange juice  4.99";
             item.Margin = new System.Windows.Thickness(696, 85, 0, 0);

            //printBill(bill);
            Button cancel = new Button();
            cancel.Name = "cancel";
            cancel.Content = "remove";
            cancel.Background = Brushes.Red;
            cancel.Width = 45;
            cancel.Height = 20;
            cancel.Margin = new System.Windows.Thickness(736, -180, 0, 0);

            Button getBill = new Button();
            getBill.Content = "Get Bill";
            getBill.Width = 80;
            getBill.Height = 25;
            getBill.Background = Brushes.LightGreen;
            getBill.Margin = new System.Windows.Thickness(700, 300, 0, 0);
           
            grid1.Children.Add(item);
            grid1.Children.Add(getBill);
            grid1.Children.Add(cancel);


        }

        private void coke_click(object sender, RoutedEventArgs e)
        {
            bill.Add(new Item("Coke", 2.99));
            // Settings to generate a New Label
           // Label item = new Label();
            //item.Content = "Coke      2.99";
           // item.Margin = new System.Windows.Thickness(696, 98, 0, 0);


           // grid1.Children.Add(item);
            
        }

        private void martini_click(object sender, RoutedEventArgs e)
        {
            bill.Add(new Item("Coke", 2.99));
            // Settings to generate a New Label
           // Label item = new Label();
           // item.Content = "Coke      2.99";
           // item.Margin = new System.Windows.Thickness(696, 118, 0, 0);


//            grid1.Children.Add(item);

        }

        private void guniess_click(object sender, RoutedEventArgs e)
        {
            bill.Add(new Item("Coke", 2.99));
            // Settings to generate a New Label
           // Label item = new Label();
           // item.Content = "Coke      2.99";
           // item.Margin = new System.Windows.Thickness(696, 138, 0, 0);


            //grid1.Children.Add(item);

        }

        private void printBill(List<Item> items)
        {
            int pos = 78;
            foreach (var item in items)
            {
                // Settings to generate a New Label
                Label lbl = new Label();
                lbl.Name = "labelID";
                lbl.Content = $"{item.name}    {item.price}";
                lbl.Margin = new System.Windows.Thickness(696, pos, 0, 0);
                grid1.Children.Add(lbl);
                pos += 20;


            }
        }
    }
}
