using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object combination = first + " " + second;
            string result = (string)combination;
            Console.WriteLine(result);
        }
    }
}
