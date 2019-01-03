using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Settings
{
  class Program
  {
    static ApplicationSettings App = new ApplicationSettings();
    //static LogWriter Log = new LogWriter(App.LogFileName);

    static void Main(string[] args)
    {
      //Console.WriteLine("Set defaults");
      //App.Defaults();

      //Console.WriteLine("Save settings");
      //App.Save();

      App.Load(@"C:\Temp\Settings.json");

      Console.WriteLine(App.DataFile);
      Console.WriteLine(App.StockDate);

      #region Experiments
      //Log.Write("Start application");

      //Console.WriteLine(App.LogLevel);
      //App.Save();

      //AppDomain ad = Thread.GetDomain();
      //Console.WriteLine($"Name of the execution: {ad.FriendlyName}");
      //Console.WriteLine($"Execution path (includes \\): {ad.BaseDirectory}");

      //Console.WriteLine($"Name: {(string.IsNullOrEmpty(Properties.Settings.Default.Name) ? "<empty>" : Properties.Settings.Default.Name)}");

      //if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
      //{
      //  Properties.Settings.Default.Path = Thread.GetDomain().BaseDirectory;
      //  Properties.Settings.Default.Save();
      //  Console.WriteLine("Setting saved");
      //}

      //Console.WriteLine($"Path: {(string.IsNullOrEmpty(Properties.Settings.Default.Path) ? "<empty>" : Properties.Settings.Default.Path)}");

      //Console.WriteLine($"ID: {Thread.GetDomain().Id}");
      //Console.WriteLine($"RelativeSearchPath: {Thread.GetDomain().RelativeSearchPath}");

      //Console.WriteLine();
      //Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");

      //Console.WriteLine($"Parameter Path: ");

      //Log.Write("Finished application");
      #endregion

      Console.Write("Press any key...");
      Console.ReadKey();
    }
  }
}
