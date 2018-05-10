﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker_Refractor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 2; i <= n; i++)

            {
                bool isPrime = true;

                for (int number = 2; number <= Math.Sqrt(i); number++)

                {

                    if (i % number == 0)

                    {

                        isPrime = false;

                        break;

                    }

                }

                Console.WriteLine($"{i} -> {isPrime}");

            }
        }
    }
}
