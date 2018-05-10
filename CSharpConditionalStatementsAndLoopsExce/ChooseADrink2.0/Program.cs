using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {quantity*0.70:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.00:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.70:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:F2}.");
                    break;

            }

        }
    }
}
