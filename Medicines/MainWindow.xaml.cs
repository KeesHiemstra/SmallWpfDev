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

namespace Medicines
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private static MedicineStock Stock = new MedicineStock();

    public MainWindow()
    {
      Stock.RecordingDate = new DateTime(year: 2018, month: 12, day: 27);
      Stock.Medicines.Add(new Medicine { Name = "Metoprololsuccinaat",
        Information = "",
        PiecesPerStrip = 10,
        StripsPerBox = 9,
        PiecesPerBox = 90,
        Stock = 2
      });

      InitializeComponent();

      DisplayDate();
    }

    private void DisplayDate()
    {
      DisplayRecordDate.SelectedDate = Stock.RecordingDate;
    }

    private void MenuExit_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
