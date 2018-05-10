using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlurals
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            bool endsInY = word.EndsWith("y");

            if (endsInY)
            {
                Console.WriteLine("{0}", word.Remove(word.Length - 1));

            }
        }
    }
}
