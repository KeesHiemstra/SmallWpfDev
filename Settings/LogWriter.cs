using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
  public class LogWriter
  {
    static private string _LogFileName;
    static private string _LogBackLog;

    public LogWriter(string LogFileName)
    {
      _LogFileName = LogFileName;
    }

    public void Write(string Message)
    {
      if (!string.IsNullOrEmpty(_LogBackLog))
      {
        _LogBackLog += "\n";
      }

      _LogBackLog += $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {Message}";

      if (string.IsNullOrEmpty(_LogFileName))
      {
        //Console.WriteLine("Added to backlog");
        return;
      }

      using (StreamWriter sw = File.AppendText(_LogFileName))
      {
        sw.WriteLine(_LogBackLog);
        _LogBackLog = "";
      }
    }
  }
}
