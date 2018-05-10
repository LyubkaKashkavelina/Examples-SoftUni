using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int filterFactorPercentages = int.Parse(Console.ReadLine());
            int uploadingTimeInSeconds = int.Parse(Console.ReadLine());

            long usefulPictures = (int)Math.Ceiling(numberOfPictures * filterFactorPercentages / 100.0);
            long forTotalTime = numberOfPictures * (long)filterTimeInSeconds;
            long forFilterTime = usefulPictures * (long)uploadingTimeInSeconds;
            long totalTime = forTotalTime + forFilterTime;
            // Console.WriteLine(Math.Ceiling(usefulPictures));
               Console.WriteLine(totalTime);

            // Console.WriteLine(TimeSpan.FromSeconds(totalTime).
            //  ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
            Console.WriteLine(totalTime%60);
            long secounds = 0;
            long minutes = 0;
            long hours = 0;
            long days = 0;

            secounds = totalTime % 60;
            totalTime = totalTime - secounds;
            hours = totalTime / 3600;
            minutes = totalTime / 60 - hours * 60;
            days = hours / 24;
            hours = totalTime / 3600 - days * 24;

            Console.WriteLine("{0}:{1}:{2}:{3}", days, hours.ToString("00"), minutes.ToString("00"), secounds.ToString("00"));
        }

    }
}
