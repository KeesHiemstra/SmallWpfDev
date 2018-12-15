using System.Windows.Input;

namespace WpfApp4.Commands
{
  public class ExtraApplicationCommands
  {
    public static RoutedUICommand ExitCmd = new RoutedUICommand("Exit the application",
                                                                "ExitCmd",
                                                                typeof(ExtraApplicationCommands));
  }
}