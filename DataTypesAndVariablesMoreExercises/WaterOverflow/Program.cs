using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sumOfLitres = 0;
            var capacity = 255;
            var capacityLeft = capacity;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
               
                if (capacityLeft - litres>=0)
                {
                    capacityLeft -= litres;
                   // Console.WriteLine(sumOfLitres);
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                

            }
            var filled = capacity - capacityLeft;
            Console.WriteLine(filled);

        }
    }
}
