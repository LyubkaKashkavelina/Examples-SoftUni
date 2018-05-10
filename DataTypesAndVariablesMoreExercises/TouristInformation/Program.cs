using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnitToConvert = Console.ReadLine();
            decimal valueToConvert = decimal.Parse(Console.ReadLine());
            decimal convertedValue = 0;
            string metricUnit = "";

          

            switch(imperialUnitToConvert)
            {
                case "miles":
                    metricUnit = "kilometers";
                    convertedValue = valueToConvert * 1.6m;
                    break;
                case "inches":
                    metricUnit = "centimeters";
                    convertedValue = valueToConvert * 2.54m;
                   break;
                case "feet":
                    metricUnit = "centimeters";
                    convertedValue = valueToConvert * 30m;
                    break;
                case "yards":
                    metricUnit = "meters";
                    convertedValue = valueToConvert * 0.91m;
                    break;
                case "gallons":
                    metricUnit = "liters";
                    convertedValue = valueToConvert * 3.8m;
                   break;
              
              
            }
            Console.WriteLine($"{valueToConvert} {imperialUnitToConvert} = {convertedValue:F2} {metricUnit}");
        }
    }
}
