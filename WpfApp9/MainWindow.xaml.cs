using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    #endregion

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
    #endregion

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
    #endregion

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
    #endregion
  }
}
