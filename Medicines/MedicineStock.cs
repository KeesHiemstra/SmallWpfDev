using System;
using System.Collections.Generic;

namespace Medicines
{
  public class MedicineStock
  {
    public DateTime RecordingDate { get; set; }
    public List<Medicine> Medicines = new List<Medicine>();

  }
}