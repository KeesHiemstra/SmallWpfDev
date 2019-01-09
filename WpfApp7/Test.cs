using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
  public class TestItem
  {
    public string Name { get; set; }
    public int Col1 { get; set; }
    public int Col2 { get; set; }
    public int Sum
    {
      get => Col1 + Col2;
      set => Sum = value;
    }
  }

  public class TestList
  {
    public ObservableCollection<TestItem> Items = new ObservableCollection<TestItem>();
  }
}
