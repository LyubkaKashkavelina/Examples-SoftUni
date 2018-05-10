using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 1; i < 10; i++)
            {
                if(number%2==0)
                {
                    Console.WriteLine("Please write an odd number.");
                    number = Math.Abs(int.Parse(Console.ReadLine()));
                }
               // else
                //{
                   // Console.WriteLine($"The number is {number}.");
               // }

            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
