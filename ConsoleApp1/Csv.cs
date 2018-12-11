using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Csv
    {
        public static List<Rain> ReadCsv(string Path)
        {
            List<Rain> data = new List<Rain>();
            string line;
            string[] field;

            if (!File.Exists(Path))
            {
                Console.WriteLine("File doesn't exist");
                return null;
            }

            try
            {
                using (StreamReader stream = new StreamReader(Path))
                {
                    while ((line = stream.ReadLine()) != null)
                    {
                        if (line != "\"Date\";\"Message\"")
                        {
                            line = line.Replace("\"", "");
                            field = line.Split(';');

                            Rain record = new Rain
                            {
                                Date = GetDate(field[0]),
                                Message = field[1]
                            };

                            data.Add(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return data;
        }

        private static DateTime GetDate(string field)
        {
            int year = int.Parse(field.Substring(0, 4));
            int month = int.Parse(field.Substring(5, 2));
            int day = int.Parse(field.Substring(8, 2));
            int hour = int.Parse(field.Substring(11, 2));
            int minute = int.Parse(field.Substring(14, 2));
            int second = int.Parse(field.Substring(17, 2));

            return new DateTime(year, month, day, hour, minute, second);
        }
    }
}