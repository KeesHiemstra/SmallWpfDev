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
            //Range: -1 (not measured)
            //        0 (0 mm rain)
            //        1 (> 0 mm rain)
            //        2 (< 1 mm rain)
            //       *3 (1 mm rain)
            //      120 (40 mm rain = maximum)

            //Falling rain
            for (int Value = -1; Value <= 40; Value++)
            {
                AddMeasure($"{Value}", "mm rain", Value);
            }

            #region Development
            //Border border = new Border();
            //border = Test;

            /*
            Random rnd = new Random();

            for (byte i = 0; i < 255; i++)
            {
                byte R = (byte)rnd.Next(0, 255);
                byte G = (byte)rnd.Next(0, 255);
                byte B = (byte)rnd.Next(0, 255);

                StackPanalMain.Children.Add(NewBlock(R, G, B));
            }
            */
            #endregion

        }

        private void AddMeasure(string Title, string Text, int Value)
        {
            byte r, g, b;

            Text = $"{Value} {Text}";
            switch (Value)
            {
                case -1:
                    r = 220;
                    g = 220;
                    b = 220;
                    Text = "Not measured";
                    break;
                case 0:
                    r = 220;
                    g = 220;
                    b = 255;
                    break;
                case 1:
                    r = 220;
                    g = 230;
                    b = 220;
                    break;
                case 2:
                    r = 220;
                    g = 240;
                    b = 220;
                    break;
                default:
                    r = (byte)(220 - Value * 5);
                    g = 255;
                    b = (byte)(220 - Value * 5);
                    break;
            }

            Text = $"{Title}\n{Text}\nR: {r}, G: {g}, B: {b}";

            StackPanalMain.Children.Add(AddBlock(Text, r, g, b));
        }

        private Border AddBlock(string Text, byte Red, byte Green, byte Blue)
        {
            Border border = new Border();
            SolidColorBrush brush = new SolidColorBrush();

            border.Margin = new Thickness(1);
            brush.Color = Color.FromRgb(Red, Green, Blue);

            border.Background = brush;
            border.Height = 8;
            border.Width = 8;

            border.ToolTip = Text;

            return border;
        }
    }
}
