using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
           
            var sumOfSbytes = 0;
            var sumOfInts = 0;
            long totalSum = 0;
            
            if(firstNumber>secondNumber)
            {
                totalSum = firstNumber * 10 + secondNumber * 4;

            }
            else
            {
                totalSum = secondNumber * 10 + firstNumber * 4;
            }
            Console.WriteLine(totalSum);

        }
    }
}
