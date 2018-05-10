using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (int firstNumber = n; firstNumber <= m; firstNumber++)
            {
                for (int secondNumber = n; secondNumber <= m; secondNumber++)
                {
                    combinations++;
                    if((firstNumber+secondNumber)==magicNumber)
                    {
                        Console.WriteLine($"Number found! {secondNumber} + {firstNumber} = {magicNumber}");
                        return;
                    }
                }

            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
