using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenByOdds
{
    class Program
    {
        public static int GetSumOfOddNumbers(int n)
        {
            int sum = 0;
            while(n>0)
            {
                int lastDigit = n % 10;
                if(lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        public static int GetSumOfEvenNumbers(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetMultipleByEvenAndOdds(int n)
        {
            int sumOfEvenNumbers = GetSumOfEvenNumbers(n);
            int sumOfOddNumbers = GetSumOfOddNumbers(n);
            return sumOfEvenNumbers * sumOfOddNumbers;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int multiple = GetMultipleByEvenAndOdds(number);
            Console.WriteLine(multiple);
        }
    }
}
