using Newtonsoft.Json;
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
    private static string StockFile = @"C:\Temp\Medicines.json";

    public MainWindow()
    {
      //Stock.RecordingDate = new DateTime(year: 2018, month: 12, day: 27);
      //Stock.Medicines.Add(new Medicine { Name = "Metoprololsuccinaat",
      //  Information = "",
      //  PiecesPerStrip = 10,
      //  StripsPerBox = 9,
      //  PiecesPerBox = 90,
      //  Stock = 2
      //});

      InitializeComponent();

      LoadData();

      DataGridMedicines.DataContext = Stock.Medicines;
    }

    private void LoadData()
    {
      using (StreamReader sr = File.OpenText(StockFile))
      {
        string json = sr.ReadToEnd();
        Stock = JsonConvert.DeserializeObject<MedicineStock>(json);
      }
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

    private void MenuOpen_Click(object sender, RoutedEventArgs e)
    {
      LoadData();
    }

    private void MenuSave_Click(object sender, RoutedEventArgs e)
    {
      Stock.Save(StockFile);
    }
  }
}
