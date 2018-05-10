using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOfTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%10==0)
                {
                    arr[i] = arr[i + 1];
                }
                Console.WriteLine();
            }

        }
    }
}
