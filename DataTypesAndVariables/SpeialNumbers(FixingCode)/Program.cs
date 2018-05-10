using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeialNumbers_FixingCode_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1;num<=n;num++)
            {
                var sumOfDigits = 0;
                var digits = num;
                while (digits> 0)
                {
                    
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
