using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var doubleRoom = 0.0;
            var suite = 0.0;

            if((month=="May")||(month=="October"))
            {
                if(nightsCount>7)
                {

                    studio= (50 * nightsCount) * 0.95;

                }
                else
                {
                    studio = nightsCount * 50;
                }
                doubleRoom = nightsCount * 65;
                suite = nightsCount * 75;

                if (month == "October"&&nightsCount>7)
                {
                    Console.WriteLine($"Studio: { studio -= 50 * 0.95:F2} lv.");
                    Console.WriteLine($"Double: {doubleRoom:F2} lv.");
                    Console.WriteLine($"Suite: {suite:F2} lv.");
                }
                else
                {

                    Console.WriteLine($"Studio: {studio:F2} lv.");
                    Console.WriteLine($"Double: {doubleRoom:F2} lv.");
                    Console.WriteLine($"Suite: {suite:F2} lv.");
                }
            }


            else if(month=="June"||month=="September")
            {
                if (nightsCount > 14)
                {
                    doubleRoom = (72 * nightsCount) * 0.9;

                }
                else
                {
                    doubleRoom = nightsCount * 72;
                }
                studio = nightsCount * 60;
                suite = nightsCount * 82;

                if (month == "September" && nightsCount > 7)
                {
                    Console.WriteLine($"Studio: { studio -= 60:F2} lv.");
                    Console.WriteLine($"Double: {doubleRoom:F2} lv.");
                    Console.WriteLine($"Suite: {suite:F2} lv.");
                }
                else
                {

                    Console.WriteLine($"Studio: {studio:F2} lv.");
                    Console.WriteLine($"Double: {doubleRoom:F2} lv.");
                    Console.WriteLine($"Suite: {suite:F2} lv.");
                }
            }
            else if(month=="July"||month=="August"||month=="December")
            {
                if (nightsCount > 14)
                {
                    suite = (89 * nightsCount) * 0.85;

                }
                else
                {
                  suite = nightsCount * 89;
                }
                
                studio = nightsCount * 68;
                doubleRoom = nightsCount * 77;

                Console.WriteLine($"Studio: {studio:F2} lv.");
                Console.WriteLine($"Double: {doubleRoom:F2} lv.");
                Console.WriteLine($"Suite: {suite:F2} lv.");
            }

        }
    }
}
