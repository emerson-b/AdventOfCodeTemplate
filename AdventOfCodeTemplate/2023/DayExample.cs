using AdventOfCode.Helpers;
using NUnit.Framework;
using System.Diagnostics;

namespace AdventOfCode._2023
{
    internal class DayExample
    {
        [Test]
        public void AdventOfCodeDayExample()
        {
            //Follow this example for your different advent days

            //Use the below Csv method to read in the input data, from the reciprocal data input file

            //Use the list to modify the data as per the requirements on the challenge

            //Use the example data given to test your code works

            //If it passes, switch the name of the file in the csv tool input from test to real

            //Output your answers into the website to see if it passes

            List<string> input = new CsvTool("dayExample_test.csv").GetStringCsvFile();


            List<int> elf = new List<int>();
            int calories = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == " ")
                {
                    elf.Add(calories);
                    calories = 0;
                }
                else 
                {
                    calories += Int32.Parse(input[i]);
                }
            }


            TestContext.Out.WriteLine("Max cals is: " + elf.Max());

            calories = 0;
            for (int i = 0; i < 3; i++)
            {
                calories += elf.Max();
                elf.Remove(elf.Max());
            }

            TestContext.Out.WriteLine("Top 3 sum max cals is: " + calories);
        }

	

	
    }
}
