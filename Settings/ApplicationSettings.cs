using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Settings
{
  public class ApplicationSettings
  {
    public string SettingFile { get; set; }
    public string DataFile { get; set; }
    public DateTime StockDate { get; set; }

    public void Defaults()
    {
      SettingFile = @"C:\Temp\Settings.json";
      DataFile = @"C:\Temp\Medicines.json";
      StockDate = new DateTime(2018, 11, 27);
    }

    public void Load(string SettingFile)
    {
      string JsonData;
      using (StreamReader sr = File.OpenText(SettingFile))
      {
        JsonData = sr.ReadToEnd();
      }

      ApplicationSettings settings = JsonConvert.DeserializeObject<ApplicationSettings>(JsonData);
      SettingFile = settings.SettingFile;
      DataFile = settings.DataFile;
      StockDate = settings.StockDate;
    }

    public void Save()
    {
      string JsonData = JsonConvert.SerializeObject(this, Formatting.Indented);
      using (StreamWriter sr = new StreamWriter(this.SettingFile))
      {
        sr.Write(JsonData);
      }
    }
  }

}

/*
    //private readonly string DataFileFull = "";
    private readonly bool Log = false;

    public string SettingsFileName { get; set; } = "";

    public string LogFileName { get; set; } = "";
    public string LogLevel { get; set; } = "Debug";

    public string DataFileName { get; set; } = "Medicines.json";
    public string DataFilePath { get; set; } = ".";

    public ApplicationSettings()
    {
      Load(GetDataFileFullName());
      //GetLogFileName();
      //GetDataFileFullName();
    }

    private void Load(string FileName)
    {
      if (!File.Exists(FileName))
      {
        if (Log)
        {
          //WriteLog: Settings don't exist
        }
        return;
      }

      string JsonData;
      using (StreamReader sr = File.OpenText(FileName))
      {
        JsonData = sr.ReadToEnd();
      }

      ApplicationSettings env = (ApplicationSettings)JsonConvert.DeserializeObject(JsonData);
    }

    public void Save()
    {
      string JsonData = JsonConvert.SerializeObject(this);
      using (StreamWriter sr = new StreamWriter(this.GetDataFileFullName()))
      {
        sr.Write(JsonData);
      }
    }

    public string GetSettingsFileName()
    {
      if (string.IsNullOrEmpty(SettingsFileName))
      {
        SettingsFileName = $"{Directory.GetCurrentDirectory()}\\{Thread.GetDomain().FriendlyName.Replace(".exe", ".json")}";
      }

      if (File.Exists(SettingsFileName))
      {
        Load(SettingsFileName);
      }

      return SettingsFileName;
    }

    public string GetLogFileName()
    {
      if (string.IsNullOrEmpty(LogFileName))
      {
        LogFileName = $"{Directory.GetCurrentDirectory()}\\{Thread.GetDomain().FriendlyName.Replace(".exe", ".log")}";
      }

      return LogFileName;
    }

    public string GetDataFileFullName()
    {
      if (DataFilePath == ".")
      {
        DataFilePath = $"{Directory.GetCurrentDirectory()}\\";
      }

      return $"{DataFilePath}{DataFileName}";
    }
*/
