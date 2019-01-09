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
using System.Windows.Shapes;

namespace Medicines
{
  /// <summary>
  /// Interaction logic for MedicineDetails.xaml
  /// </summary>
  public partial class MedicineDetails : Window
  {
    private MedicineItem _Medicine;

    public MedicineDetails(MedicineItem medicine)
    {
      _Medicine = medicine;

      InitializeComponent();
    }

    private void ButtonDetailsOK_Click(object sender, RoutedEventArgs e)
    {
    
    }

    private void ButtonDetailsCancel_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

  }
}
