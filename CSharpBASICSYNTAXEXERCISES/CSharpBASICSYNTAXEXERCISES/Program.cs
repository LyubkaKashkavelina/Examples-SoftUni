using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBASICSYNTAXEXERCISES
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var forthNumber = int.Parse(Console.ReadLine());

            Console.Write($"{firstNumber:D4} ");
            Console.Write($"{secondNumber:D4} ");
            Console.Write($"{thirdNumber:D4} ");
            Console.Write($"{forthNumber:D4}");

        }
    }
}
