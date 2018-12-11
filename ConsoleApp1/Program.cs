using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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
