using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int photoSizeInBytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            if (photoSizeInBytes <= 99999)
            {
                Console.WriteLine($"Size: {photoSizeInBytes}B");
            }
            else if (photoSizeInBytes >= 100000 && photoSizeInBytes < 1000000)
            {
                var kb = photoSizeInBytes / 1000;
                Console.WriteLine($"Size: {kb}KB");

            }
            else if (photoSizeInBytes >= 1000000)
            {
                var mb = (double)photoSizeInBytes / 1000000;
                Console.WriteLine($"Size: {mb}MB");
            }
            // Console.WriteLine($"Resolution: {width}x{height} ");

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");







            }
        }
    }
}
