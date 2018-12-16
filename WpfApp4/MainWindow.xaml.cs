﻿using System;
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
    private static Client CurrentClient = new Client();

    public MainWindow()
    {
      InitializeComponent();
      InitializeClients();
    }

    private void InitializeClients()
    {
      LoadClients();

      //Fill menu Main-Client
      foreach (var client in Clients)
      {
        NewMenuItem(client);
      }

      UpdateCurrentClient(0);
    }

    private void UpdateCurrentClient(int clientID)
    {
      CurrentClient = Clients[clientID];
      StatusBarClientShortName.Text = CurrentClient.ShortName;
    }

    private void LoadClients()
    {
      Clients.Add(new Client { Id = 0, Name = "Personal", ShortName = "CHi", Active = true });
      Clients.Add(new Client { Id = 1, Name = "DiTP", ShortName = "ditp", Active = true });
      Clients.Add(new Client { Id = 2, Name = "DTC (HPE,Hewlett-Pacard)", ShortName = "HP", Active = false });
    }

    private void NewMenuItem(Client client)
    {
      int Counter = MenuFileClient.Items.Count;
      MenuItem addMenuItem = new MenuItem
      {
        Header = client.ShortName,
        Command = Commands.ExtraApplicationCommands.ClientCmd
      };
      //if (client.Active && Counter < 9)
      //{
      //  addMenuItem.InputGestureText = $"Ctrl-{Counter + 1}";
      //}
      MenuFileClient.Items.Add(addMenuItem);
    }

    private void ExitCmd_Executed(object sender, ExecutedRoutedEventArgs e)
    {
      //Close the appplication
      this.Close();
    }

    private void ExitCmd_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }

    private void ClientCmd_Executed(object sender, ExecutedRoutedEventArgs e)
    {
      var SelectedClient = e.Source.Header;
    }

    private void ClientCmd_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }
  }
}