using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] arrayFromTheBeginning = new int[n];
            int[] arrayFromTheEnd = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = 0; i < n; i++)
                {
                    arr[j] = arrayFromTheBeginning[n];
                }
                for (int j = arr[arr.Length - 1]; i > n; i--)
                {
                    arr[j] = arrayFromTheEnd[n];
                }
                if (arrayFromTheBeginning == arrayFromTheEnd)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
