using CsvHelper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Helpers
{
    
    class CsvTool
    {
        private string csvFile;
        public CsvTool(string csvFile) 
        {
            this.csvFile = Path.Combine(Path.GetDirectoryName(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName), 
                TestContext.Parameters.Get("YEAR"), 
                "inputs", csvFile);
        }


        public List<int> GetIntCsvFile()
        {
            List<int> csvOutput = new List<int>();
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var record = new IntCsv();
                    var records = csv.EnumerateRecords(record);
                    foreach (var r in records)
                    {
                        csvOutput.Add(r.Input);
                    }
                    return csvOutput;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> GetStringCsvFile()
        {
            List<string> csvOutput = new List<string>();
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var record = new StringCsv();
                    var records = csv.EnumerateRecords(record);
                    foreach (var r in records)
                    {
                        csvOutput.Add(r.Input);
                    }
                    return csvOutput;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public class IntCsv
        {
            public int Input { get; set; }
        }

        public class StringCsv
        {
            public string? Input { get; set; }
        }
    }
}
 