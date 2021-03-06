﻿using Newtonsoft.Json;
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
    private static MedicineList Stock = new MedicineList();
    private static string StockFileName = GetStockFileName();

    public MainWindow()
    {
      InitializeComponent();

      LoadData();
      UpdateDateGridMedicines();

      DataGridMedicines.DataContext = Stock.Medicines;
    }

    private void UpdateDateGridMedicines()
    {
      Stock.UpdateRecordingDates();
    }

    private void LoadData()
    {
      using (StreamReader sr = File.OpenText(StockFileName))
      {
        string json = sr.ReadToEnd();
        Stock = JsonConvert.DeserializeObject<MedicineList>(json);
      }
      DisplayDate();
    }

    private void DisplayDate()
    {
      DisplayRecordDate.SelectedDate = Stock.RecordingDate;
    }

    private static string GetStockFileName()
    {
      string OneDrive = Environment.GetEnvironmentVariable("OneDrive");
      string stockFile = $"{OneDrive}\\Data\\Medicines.json";

      return stockFile;
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
      Stock.Save(StockFileName);
    }

    private void MenuDataDetails_Click(object sender, RoutedEventArgs e)
    {
      

      //MedicineDetails medicineDetails = new MedicineDetails();
      //medicineDetails.Show();
    }
  }
}
