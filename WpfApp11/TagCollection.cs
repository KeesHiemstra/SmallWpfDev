using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp11
{
  public class TagItem
  {
    public string Name { get; set; }
    public List<string> Properties { get; set; }
    public string Text { get; set; }
    public int Level { get; set; }

  }

  public class TagCollection
  {
    public List<TagItem> Tags { get; set; }

    private static int CurrentLevel = 0;

    public void Parse(string page)
    {
      string pattern = @"(<.\w.*>)|(.*)";
      Regex regex = new Regex(pattern);

      var matches = regex.Matches(page);

      foreach (var match in matches)
      {
        MessageBox.Show(match.ToString());
      }

      //TagItem Tag = new TagItem();

      //int TagStart = page.IndexOf('<');
      //int TagEnd = page.IndexOf('>');
      //int TextStart;
      //int TextEnd;
      //string TagText;

      //do
      //{
      //  TagText = page.Substring(TagStart + 1, TagEnd - TagStart -1);
      //  //Tag found

      //  TextStart = TagEnd + 1;


      //  TagStart = page.IndexOf('<', TagEnd + 1);
      //  TagEnd = page.IndexOf('<', TagEnd + 1);
 
      //} while (TagEnd < 0);
    }
  }
}
