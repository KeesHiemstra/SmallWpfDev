using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
  public class LoadPage
  {
    public string Result { get; set; }

    public async Task GetPageAsync(string pageUrl)
    {
      var http = new HttpClient();
      var httpRespond = await http.GetAsync(pageUrl);
      Result = await httpRespond.Content.ReadAsStringAsync();
    }
  }
}
