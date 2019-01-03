using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Medicines
{
  public class MedicineStock
  {
    public DateTime RecordingDate { get; set; }
    public List<Medicine> Medicines = new List<Medicine>();

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