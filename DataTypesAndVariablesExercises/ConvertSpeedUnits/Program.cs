using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalTimeInSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float distanceInKilometres = distance / 1000;
            float inMiles =(float) distance / 1609;
            
            Console.WriteLine(distance/totalTimeInSeconds);
            Console.WriteLine(distanceInKilometres / (totalTimeInSeconds / 3600));
            Console.WriteLine(inMiles/(totalTimeInSeconds/3600));
        }
    }
}
