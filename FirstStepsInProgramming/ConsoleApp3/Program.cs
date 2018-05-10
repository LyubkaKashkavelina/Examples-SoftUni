using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {ID:D8}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
