using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp4
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private static List<Client> Clients = new List<Client>();

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
      foreach (var client in Clients)
      {
        NewMenuItem(client);
      }
    }

    private void NewMenuItem(Client client)
    {
      int Counter = MenuFileClient.Items.Count;
      MenuItem addMenuItem = new MenuItem
      {
        Header = client.ShortName
      };
      if (client.Active && Counter < 9)
      {
        addMenuItem.InputGestureText = $"Ctrl-{Counter + 1}";
      }
      MenuFileClient.Items.Add(addMenuItem);
    }

    private void ExitCmd_Executed(object sender, ExecutedRoutedEventArgs e)
    {
      //Close the appplication
      this.Close();
    }

    private void ExitCmd_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {

    }
  }
}