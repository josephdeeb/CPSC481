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

        public bool bobSelected, amySelected = true;
        List<Item> bill = new List<Item>();
        public Homepage()
        {
            InitializeComponent();
        }

        private void idleScreen_grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Visible;
            dimming_grid.IsEnabled = true;
        }

        private void name_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && name_textbox.Text != null)
            {
                dimming_grid.Visibility = Visibility.Hidden;
                dimming_grid.IsEnabled = false;

                idleScreen_grid.Visibility = Visibility.Collapsed;
                idleScreen_grid.IsEnabled = false;

                layout_grid.Visibility = Visibility.Visible;
                layout_grid.IsEnabled = true;

                if (name_textbox.Text == "Amy")
                {
                    amy_name_button.Visibility = Visibility.Visible;
                }
            }
        }

        private void drink_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            drink_button.Foreground = new SolidColorBrush(Color.FromRgb(87, 87, 87));
            drink_button.Background = new SolidColorBrush(Color.FromRgb(232, 228, 223));

            appetizer_button.Foreground = new SolidColorBrush(Color.FromRgb(70, 70, 70));
            appetizer_button.Background = new SolidColorBrush(Color.FromRgb(182, 169, 169));
        }

        private void appetizer_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            appetizer_button.Foreground = new SolidColorBrush(Color.FromRgb(87, 87, 87));
            appetizer_button.Background = new SolidColorBrush(Color.FromRgb(232, 228, 223));

            drink_button.Foreground = new SolidColorBrush(Color.FromRgb(70, 70, 70));
            drink_button.Background = new SolidColorBrush(Color.FromRgb(182, 169, 169));
        }

        // Help Button Methods
        private void help_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            help_button.Background = new SolidColorBrush(Color.FromRgb(226, 97, 97));
            help_button.Foreground = new SolidColorBrush(Color.FromRgb(52, 51, 50));
        }

        private void help_button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            help_button.Background = new SolidColorBrush(Color.FromRgb(52, 51, 50));
            help_button.Foreground = new SolidColorBrush(Color.FromRgb(232, 228, 223));
        }

        // Name Button Methods
        private void add_name_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dimming_grid.Visibility = Visibility.Visible;
            dimming_grid.IsEnabled = true;
        }

        private void bob_name_button_MouseDown(object sender, MouseButtonEventArgs e)
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
    }
}
