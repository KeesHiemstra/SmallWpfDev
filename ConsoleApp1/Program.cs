using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      //Settings
      string FilePath = @"C:\Users\Kees\OneDrive\Data\Rain.csv";

      //Data
      List<Rain> FallenRain = new List<Rain>();

      FallenRain = Csv.ReadCsv(FilePath);

      Console.WriteLine(FallenRain.Count);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}