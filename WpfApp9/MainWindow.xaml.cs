﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp9
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : INotifyPropertyChanged
  {
    public MainWindow()
    {
      DataContext = this;
      InitializeComponent();
      Arg1.Focus();
    }

    #region Argument1

    private int _Argument1 = -1;

    public int Argument1
    {
      get => _Argument1;
      set
      {
        if (_Argument1 != value)
        {
          _Argument1 = value;
          OnPropertyChanged("Result");
        }
      }
    }

    #endregion Argument1

    #region Argument2

    private int _Argument2 = -2;

    public int Argument2
    {
      get => _Argument2;
      set
      {
        if (_Argument2 != value)
        {
          _Argument2 = value;
          OnPropertyChanged("Result");
        }
      }
    }

    #endregion Argument2

    #region Result

    private int _Result = -9;

    public int Result
    {
      get => CalulateResult();
      set
      {
        if (_Result != value)
        {
          _Result = Argument1 + Argument2;
          OnPropertyChanged();
        }
      }
    }

    #endregion Result

    private int CalulateResult()
    {
      return _Argument1 + _Argument2;
    }

    #region Notification interface

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion Notification interface
  }
}