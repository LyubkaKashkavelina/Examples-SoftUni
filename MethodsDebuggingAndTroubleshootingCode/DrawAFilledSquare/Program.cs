using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void PrintTopPart(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMiddlePart(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTopPart(num);
            for (int i = 1; i <= num-2; i++)
            {
                PrintMiddlePart(num);
            }
           
            PrintTopPart(num);
        }
    }
}
