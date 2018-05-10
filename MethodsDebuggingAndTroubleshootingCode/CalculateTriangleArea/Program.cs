using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static double CalculateAreaOfTriangle(double side, double width)
        {
            return side * width / 2;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double hA = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(CalculateAreaOfTriangle(a,hA))}");
        }
    }
}
