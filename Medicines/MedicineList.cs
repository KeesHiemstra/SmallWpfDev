using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Medicines
{
  public class MedicineList
  {
    public DateTime RecordingDate { get; set; }
    public ObservableCollection<MedicineItem> Medicines = new ObservableCollection<MedicineItem>();

    public void UpdateRecordingDates()
    {
      foreach (var item in Medicines)
      {
        if (item.RecordingDate == new DateTime(1, 1, 1))
        {
          item.RecordingDate = RecordingDate;
        }
      }
    }

    public void Save(string Path)
    {
      string json = JsonConvert.SerializeObject(this, Formatting.Indented);
      using (StreamWriter stream = new StreamWriter(Path))
      {
        stream.Write(json);
      }
    }
  }
}