using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var sum = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");



        }
    }
}
