using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            var bars = (double)beats / 4;
            int minutes = beats / beatsPerMinute;
            double seconds = Math.Floor(60 * (beats / (double)beatsPerMinute) - minutes * 60); 
            Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {seconds}s");
        }
    }
}
