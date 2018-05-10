using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConvertion
{
    class Program
    {
        static double FahrenheitToCelsius(double degree)
        {
            return (degree - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{FahrenheitToCelsius(fahrenheit):F2}");
           
        }
    }
}
