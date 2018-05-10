using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInHexidecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(one,16));
        }
    }
}
