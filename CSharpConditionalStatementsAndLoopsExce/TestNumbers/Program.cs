using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int combinations =0;
            bool isBiggerOrEven = false;

            for (int firstNumber = n; firstNumber >= 1; firstNumber--)
            {
                for (int secondNumber = 1; secondNumber <= m; secondNumber++)
                {
                    combinations++;
                    var numberOfTwoDigits = firstNumber * secondNumber;
                    var newNumber = numberOfTwoDigits * 3;
                    totalSum += newNumber;
                   


                    if (totalSum >= maxSumBoundary)
                    {
                        //Console.WriteLine($"{combinations} combinations\nSum: {totalSum} >= {maxSumBoundary}");
                       // return;
                        isBiggerOrEven = true;
                        Console.WriteLine($"{combinations} combinations\nSum: {totalSum} >= {maxSumBoundary}");
                        return;


                    }
                    else
                    {
                        //Console.WriteLine($"{combinations} combinations\nSum: {totalSum}");
                        isBiggerOrEven = false;
                    }

                }
               
            }
            
           
                Console.WriteLine($"{combinations} combinations\nSum: {totalSum}");
           
           



        }
    }
}
