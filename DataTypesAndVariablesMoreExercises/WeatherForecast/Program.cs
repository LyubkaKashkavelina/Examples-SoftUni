using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            try
            {
                sbyte input = sbyte.Parse(number);
                Console.WriteLine("Sunny");
                return;
            }
            catch
            {

            }
            try
            {
               int input = int.Parse(number);
                Console.WriteLine("Cloudy");
                return;
            }
            catch
            {

            }
            try
            {
                long input = long.Parse(number);
                Console.WriteLine("Windy");
                return;
            }
            catch
            {

            }
            try
            {
                float input = float.Parse(number);
                Console.WriteLine("Rainy");
                return;
            }
            catch
            {

            }
        }
    }
}
