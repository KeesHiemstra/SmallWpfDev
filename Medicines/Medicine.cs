using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines
{
  public class Medicine
  {
    /// <summary>
    /// Fields to store in a json file.
    /// </summary>
    public string Name { get; set; }
    public string Information { get; set; }
    public int PiecesPerStrip { get; set; }
    public int StripsPerBox { get; set; }
    public int PiecesPerBox { get; set; }
    public bool IsService { get; set; }
    public int Stock { get; set; }

    /// <summary>
    /// Calculate fields.
    /// </summary>
    virtual public DateTime EmptyDate { get; set; }
    virtual public int Actual { get; set; }
  }
}
