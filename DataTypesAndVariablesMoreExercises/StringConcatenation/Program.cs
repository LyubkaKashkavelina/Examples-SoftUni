using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine().ToLower().Trim();
            int n = int.Parse(Console.ReadLine());
            string messege = string.Empty;
            int result = 0;
            if(evenOrOdd=="odd")
            {
                result = 1;
            }
            for (int i = 1; i <= n; i++)
            {
                string theString = Console.ReadLine();
                if(i%2==result)
                {
                    messege += theString + delimiter;
                }
               
            }
            Console.WriteLine($"{messege.Remove(messege.Length-1)}");
        }
    }
}
