using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp3
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private static DateTime PageDate = DateTime.Now.AddDays(-1);

    public MainWindow()
    {
      InitializeComponent();

      MainPageDate.DisplayDateEnd = DateTime.Now.AddDays(-1);
      MainPageDate.Text = PageDate.ToString();

      GetPage($"https://www.uitzendinggemist.net/op/{PageDate.ToString("ddMMyyyy")}.html");
    }

    private void GetPage(string PageUrl)
    {
      TabSourceBrowser.Source = new Uri(PageUrl);
      var http = new HttpClient();
      //var httpRespond = await http.Get
    }
  }
}
