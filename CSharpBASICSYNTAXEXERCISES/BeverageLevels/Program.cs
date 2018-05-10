using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            double kcal = (double)volume * (double)energyContent / 100;
            double sugars = (double)volume * (double)sugarContent / 100;
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");

        }
    }
}
