using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines
{
  public class Medicine
  {
    public string Name { get; set; }
    public string Information { get; set; }
    public int PiecesPerStrip { get; set; }
    public int StripsPerBox { get; set; }
    public int PiecesPerBox { get; set; }
    public int Stock { get; set; }
  }
}
