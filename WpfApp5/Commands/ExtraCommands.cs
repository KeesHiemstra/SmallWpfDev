using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp5.Commands
{
  public class ExtraCommands
  {
    //public static RoutedUICommand ExitCmd = new RoutedUICommand();

    public static RoutedUICommand ExitCmd = new
      RoutedUICommand("Exit the application", "ExitCmd", typeof(ExtraCommands));
  }
}
