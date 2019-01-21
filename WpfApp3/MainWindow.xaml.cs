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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

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

      GetPageAsync($"https://www.uitzendinggemist.net/op/{PageDate.ToString("ddMMyyyy")}.html");
    }

    private async Task GetPageAsync(string PageUrl)
    {
      MainPageDateDay.Text = PageDate.DayOfWeek.ToString();
      TabSourceBrowser.Source = new Uri(PageUrl);
      var http = new HttpClient();
      var httpRespond = await http.GetAsync(PageUrl);
      string httpResult = await httpRespond.Content.ReadAsStringAsync();
      TabSouceText.Text = httpResult;

      //HtmlDocument doc = new HtmlDocument();

      //IHTMLDocument2 htmlDocument = (IHTMLDocument2)new mshtml.HTMLDocument();

    }

    private void TabSouceText_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
    {

    }
  }
}
