using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
  public class Calculate : INotifyPropertyChanged
  {
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

    private int _Result = -9;
    public int Result
    {
      get => CalulateResult();
      set
      {
        if (_Result != value)
        {
          _Result = CalulateResult();
          OnPropertyChanged();
        }
      }
    }

    private int CalulateResult()
    {
      return _Argument1 + _Argument2;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
