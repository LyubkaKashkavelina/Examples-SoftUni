using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static double RaiseToPower(double number, double pow)
        {
            double result = 0.0;
            result = Math.Pow(number, pow);
            return result;
        }
        static void Main(string[] args)
        {
            double osnova = double.Parse(Console.ReadLine());
            double stepen = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(osnova,stepen));
        }
    }
}
