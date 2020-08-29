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

namespace myWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //creates a new Grid
          /*  Grid grid = new Grid();
            this.Content = grid;

            //button
            Button button = new Button();
            button.FontSize = 26;
            button.Height = 100;
            button.Width = 180;

            WrapPanel wrappannel = new WrapPanel();
            TextBlock textInButton = new TextBlock();

          
            textInButton.Text = "Hello World";
            textInButton.Foreground = Brushes.Gray;

            wrappannel.Children.Add(textInButton);
            button.Content = wrappannel;
            grid.Children.Add(button);*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mouse button went up was realeased");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("preview mouse button went up was realeased");
        }
    }
}
