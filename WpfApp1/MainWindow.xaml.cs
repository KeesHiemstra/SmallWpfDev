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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            //Border border = new Border();
            //border = Test;

            Random rnd = new Random();

            for (byte i = 0; i < 255; i++)
            {
                byte R = (byte)rnd.Next(0, 255);
                byte G = (byte)rnd.Next(0, 255);
                byte B = (byte)rnd.Next(0, 255);

                StackPanalMain.Children.Add(NewBlock(R, G, B));
            }

        }

        private Border NewBlock(byte Red, byte Green, byte Blue)
        {
            Border border = new Border();
            SolidColorBrush brush = new SolidColorBrush();

            border.Margin = new Thickness(1);
            brush.Color = Color.FromRgb(Red, Green, Blue);

            border.Background = brush;
            border.Height = 8;
            border.Width = 8;

            return border;
        }
    }
}
