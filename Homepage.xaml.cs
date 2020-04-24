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
        public bool options, bobSelected, amySelected, olives, extracheese = false;
        public bool callHelp = true;

        public Homepage()
        {
            InitializeComponent();
        }

        private void idleScreen_grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Visible;
            dimming_grid.IsEnabled = true;

            name_prompt.Visibility = Visibility.Visible;
            pass_prompt.Visibility = Visibility.Collapsed;
            keyboard_image.Visibility = Visibility.Visible;
        }

        private void name_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && name_textbox.Text != null)
            {
                dimming_grid.Visibility = Visibility.Collapsed;
                dimming_grid.IsEnabled = false;
                name_prompt.Visibility = Visibility.Collapsed;
                pass_prompt.Visibility = Visibility.Collapsed;
                keyboard_image.Visibility = Visibility.Collapsed;

                idleScreen_grid.IsEnabled = false;

                layout_grid.Visibility = Visibility.Visible;
                layout_grid.IsEnabled = true;

                if (name_textbox.Text == "Amy")
                {
                    amy_name_button.Visibility = Visibility.Visible;
                }
                else if (name_textbox.Text == "573V3N")
                {
                    // CODE HERE FOR SHOWING DELETION OPTIONS
                    bobsDrink_removal_button.Visibility = Visibility.Visible;
                    amysDrink_removal_button.Visibility = Visibility.Visible;
                    nacho_removal_button.Visibility = Visibility.Visible;
                }
                name_textbox.Text = "";
            }
        }

        private void dimming_grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Collapsed;
            dimming_grid.IsEnabled = false;
            placeOrder_grid.Visibility = Visibility.Collapsed;
            keyboard_image.Visibility = Visibility.Collapsed;
        }

        // Category Button Methods
        private void drink_button_Click(object sender, RoutedEventArgs e)
        {
            drink_button.Foreground = new SolidColorBrush(Color.FromRgb(87, 87, 87));
            drink_button.Background = new SolidColorBrush(Color.FromRgb(232, 228, 223));
            
            drinks_viewer.Visibility = Visibility.Visible;
            appetizers_viewer.Visibility = Visibility.Collapsed;

            appetizer_button.Foreground = new SolidColorBrush(Color.FromRgb(70, 70, 70));
            appetizer_button.Background = new SolidColorBrush(Color.FromRgb(182, 169, 169));
        }
        private void appetizer_button_Click(object sender, RoutedEventArgs e)
        {
            appetizer_button.Foreground = new SolidColorBrush(Color.FromRgb(87, 87, 87));
            appetizer_button.Background = new SolidColorBrush(Color.FromRgb(232, 228, 223));

            appetizers_viewer.Visibility = Visibility.Visible;
            drinks_viewer.Visibility = Visibility.Collapsed;

            drink_button.Foreground = new SolidColorBrush(Color.FromRgb(70, 70, 70));
            drink_button.Background = new SolidColorBrush(Color.FromRgb(182, 169, 169));
        }

        // Help Button Methods
        private void help_button_Click(object sender, RoutedEventArgs e)
        {
            if (callHelp)
            {
                callHelp = false;
                help_button.Background = new SolidColorBrush(Color.FromRgb(226, 97, 97));
                help_button.Foreground = new SolidColorBrush(Color.FromRgb(52, 51, 50));
            }
            else
            {
                callHelp = true;
                // CODE HERE FOR HIDING DELETION BUTTONS
                bobsDrink_removal_button.Visibility = Visibility.Collapsed;
                amysDrink_removal_button.Visibility = Visibility.Collapsed;
                nacho_removal_button.Visibility = Visibility.Collapsed;
                help_button.Background = new SolidColorBrush(Color.FromRgb(52, 51, 50));
                help_button.Foreground = new SolidColorBrush(Color.FromRgb(232, 228, 223));
            }   
        }
        private void help_button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Visible;
            dimming_grid.IsEnabled = true;

            name_prompt.Visibility = Visibility.Collapsed;
            pass_prompt.Visibility = Visibility.Visible;
            keyboard_image.Visibility = Visibility.Visible;
        }

        // Name Button Methods
        private void add_name_button_Click_1(object sender, RoutedEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Visible;
            dimming_grid.IsEnabled = true;

            name_prompt.Visibility = Visibility.Visible;
            pass_prompt.Visibility = Visibility.Collapsed;
            keyboard_image.Visibility = Visibility.Visible;
        }

        private void amy_name_button_Click(object sender, RoutedEventArgs e)
        {
            if (amySelected)
            {
                amySelected = false;
                amy_name_button.BorderBrush = new SolidColorBrush(Color.FromRgb(54, 228, 255));
            }
            else
            {
                amySelected = true;
                amy_name_button.BorderBrush = Brushes.White;
            }
        }

        private void bob_name_button_Click_1(object sender, RoutedEventArgs e)
        {
            if (bobSelected)
            {
                bobSelected = false;
                bob_name_button.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 205, 83));
            }
            else
            {
                bobSelected = true;
                bob_name_button.BorderBrush = Brushes.White;
            }
        }

        // Example Steps
        private void add_bobsDrink_Click(object sender, RoutedEventArgs e)
        {
            bobs_drink_grid.Visibility = Visibility.Visible;
            bill_grid.Visibility = Visibility.Visible;
        }

        private void add_amysDrink_Click(object sender, RoutedEventArgs e)
        {
            amys_drink_grid.Visibility = Visibility.Visible;
            totalAmount_textblock.Text = "$19.80";
        }

        private void nachos_options_button_Click(object sender, RoutedEventArgs e)
        {
            if (options)
            {
                options = false;
                nachos_menu_grid.Height = 100;
                nachos_options_grid.Visibility = Visibility.Collapsed;
            }
            else
            {
                options = true;
                nachos_menu_grid.Height = 200;
                nachos_options_grid.Visibility = Visibility.Visible;
            }
        }

        private void add_nachos_button_Click(object sender, RoutedEventArgs e)
        {
            nacho_removal_button.Visibility = Visibility.Visible;
            nachos_grid.Visibility = Visibility.Visible;

            totalAmount_textblock.Text = "$32.70";
            checkout_button.Background = new SolidColorBrush(Color.FromRgb(143, 241, 86));
            checkout_button.Content = "Place Order";

            options = false;
            nachos_menu_grid.Height = 100;
            nachos_options_grid.Visibility = Visibility.Collapsed;
        }

        private void nacho_removal_button_Click(object sender, RoutedEventArgs e)
        {
            nachos_grid.Visibility = Visibility.Collapsed;
            nachos_rectangle.Fill = new SolidColorBrush(Color.FromRgb(220,200,160));
            nachos_grid_textblock.Text = "extra cheese, 'red onions instead of...'";
            totalAmount_textblock.Text = "$19.80";
        }

        private void olive_button_Click(object sender, RoutedEventArgs e)
        {
            if (olives)
            {
                olives = false;
                olive_button.Background = Brushes.White;
            }
            else
            {
                olives = true;
                olive_button.Background = new SolidColorBrush(Color.FromRgb(143, 241, 86));
            }
        }

        private void cheese_button_Click(object sender, RoutedEventArgs e)
        {
            if (extracheese)
            {
                extracheese = false;
                cheese_button.Background = Brushes.White;
            }
            else
            {
                extracheese = true;
                cheese_button.Background = new SolidColorBrush(Color.FromRgb(143, 241, 86));
            }
        }

        private void bob_Click(object sender, RoutedEventArgs e)
        {
            bob.BorderBrush = Brushes.White;
        }

        private void nachos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nachos_blueline.Width = 92;
            nachos_blueline.Margin = new Thickness(-101,50,0,0);
            nachos_yellowline.Visibility = Visibility.Visible;
            bobsBill.Content = "$16.35";
            amysBill.Content = "$16.35";
        }

        private void select_all_Click(object sender, RoutedEventArgs e)
        {
            bobsBill.Background = new SolidColorBrush(Color.FromRgb(143, 241, 86));
            amysBill.Background = new SolidColorBrush(Color.FromRgb(143, 241, 86));
        }

        private void request_bills_Click(object sender, RoutedEventArgs e)
        {
            checkout_grid.Visibility = Visibility.Collapsed;
            checkout_grid.IsEnabled = false;
            layout_grid.Visibility = Visibility.Collapsed;
            layout_grid.IsEnabled = false;
        }

        // Bill Buttons
        private void checkout_button_Click(object sender, RoutedEventArgs e)
        {
            if ((String)checkout_button.Content == "Place Order")
            {
                // BETTER IDEAS HERE, BUT FIRST...
                checkout_button.Content = "Retrieve Bill";
                checkout_button.Background = new SolidColorBrush(Color.FromRgb(230, 225, 125));

                
                amys_drink_rectangle.Fill = new SolidColorBrush(Color.FromRgb(232, 228, 223));
                amysDrink_removal_button.Visibility = Visibility.Collapsed;
                bobs_drink_rectangle.Fill = new SolidColorBrush(Color.FromRgb(232, 228, 223));
                bobsDrink_removal_button.Visibility = Visibility.Collapsed;
                if (nachos_grid.Visibility == Visibility.Visible)
                {
                    nachos_rectangle.Fill = new SolidColorBrush(Color.FromRgb(232, 228, 223));
                    nacho_removal_button.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                // OPEN CHECKOUT SCREEN
                checkout_grid.Visibility = Visibility.Visible;
                checkout_grid.IsEnabled = true;
            }
        }
    }
}
