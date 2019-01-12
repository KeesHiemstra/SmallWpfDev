using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp8
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
    }

    private void Reset_Click(object sender, RoutedEventArgs e)
    {
      Number = 0;
    }

    private int _Number;
    public int Number
    {
      get { return _Number; }
      set
      {
        if (_Number != value)
        {
          _Number = value;
          OnPropertyChanged();
        }
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}