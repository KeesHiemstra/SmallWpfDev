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

namespace WpfApp4
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    static List<Client> Clients = new List<Client>();

    public MainWindow()
    {
      InitializeComponent();
      InitializeClients();
    }

    private void InitializeClients()
    {
      Clients.Add(new Client { Id = 0, Name = "Personal", ShortName = "CHi", Active = true });
      Clients.Add(new Client { Id = 1, Name = "DiTP", ShortName = "ditp", Active = true });
      Clients.Add(new Client { Id = 2, Name = "DTC (HPE,Hewlett-Pacard)", ShortName = "HP", Active = false });

      //Fill menu Main-Client
      //MenuFileClient.Items.Add(new MenuItem {  } )
      foreach (var client in Clients)
      {
        NewMenuItem(client);
      }
    }

    private void NewMenuItem(Client client)
    {
      int Counter = MenuFileClient.Items.Count;
      MenuItem addMenuItem = new MenuItem();
      addMenuItem.Header = client.ShortName;
      if (client.Active && Counter < 9)
      {
        addMenuItem.InputGestureText = $"Ctrl-{Counter + 1}";
      }
      MenuFileClient.Items.Add(addMenuItem);
    }

    private void MenuFileExit_Click(object sender, RoutedEventArgs e)
    {
      // Exit the application
      this.Close();
    }
  }
}
