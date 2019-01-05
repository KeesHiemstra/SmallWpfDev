using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Medicines
{
  public class MedicineStock
  {
    public DateTime RecordingDate { get; set; }
    public ObservableCollection<Medicine> Medicines = new ObservableCollection<Medicine>();

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