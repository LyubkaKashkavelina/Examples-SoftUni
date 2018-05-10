using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = int.Parse(Console.ReadLine());
            var numberOfIntegers = 0;

            try
            {
                for (int i = 1; i < 100; i++)
                {
                    var input = int.Parse(Console.ReadLine());
                    numberOfIntegers++;
                }
               
            }
            catch(Exception)
            {
               // Console.WriteLine(numberOfIntegers);
            }
            Console.WriteLine(numberOfIntegers);
        }
    }
}
