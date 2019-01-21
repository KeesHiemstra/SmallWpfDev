using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WpfApp11
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private string Page;
    private TagCollection PageTags = new TagCollection();
    private int Waited;

    public MainWindow()
    {
      InitializeComponent();
    }

    private async Task RunAsync()
    {
      LoadPage loadPage = new LoadPage();

      DateTime PageDate = DateTime.Now.Date.AddDays(-1);
      string PageUrl = $"https://www.uitzendinggemist.net/op/{PageDate.ToString("ddMMyyyy")}.html";

      await loadPage.GetPageAsync(PageUrl);
      Page = loadPage.Result;

      while (Page == null)
      {
        Thread.Sleep(1000);
        Waited++;
        if (Waited == 10)
        {
          break;
        }
      }

      if (Page != null)
      {
        PageTags.Parse(Page);
      }
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
      RunAsync();
    }

  }
}
