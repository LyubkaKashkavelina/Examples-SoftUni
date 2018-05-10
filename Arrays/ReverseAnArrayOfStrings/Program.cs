using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        public static void SwapElements (string[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }

        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < nums.Length/2; i++)
            {


                SwapElements(nums, i, nums.Length - i - 1);
            }
            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
