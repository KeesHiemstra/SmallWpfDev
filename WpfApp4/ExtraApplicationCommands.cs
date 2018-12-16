using System.Windows.Input;

namespace WpfApp4.Commands
{
  public class ExtraApplicationCommands
  {
    public static RoutedUICommand ExitCmd = new RoutedUICommand("Exit the application",
                                                                "ExitCmd",
                                                                typeof(ExtraApplicationCommands));
    public static RoutedUICommand ClientCmd = new RoutedUICommand("Switch current client",
                                                                  "ClientCmd",
                                                                  typeof(ExtraApplicationCommands));
  }
}