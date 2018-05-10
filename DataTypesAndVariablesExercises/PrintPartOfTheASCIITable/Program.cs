using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstBorder = int.Parse(Console.ReadLine());
            int secondBorder = int.Parse(Console.ReadLine());

            for (int i = firstBorder; i <= secondBorder; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
