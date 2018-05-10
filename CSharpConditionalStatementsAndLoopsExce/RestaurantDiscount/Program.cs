using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var price = 0;
            double perDiscount = 0.0;

            if (groupSize >= 1 && groupSize <= 50)
            {
                //var hallName = "Small hall";
                if (package == "Gold")
                {

                    price = 750;
                    perDiscount = 0.1;


                }
                else if (package == "Normal")
                {
                    price = 500;
                    perDiscount = 0.05;

                }
                else if (package == "Platinum")
                {
                    price = 1000;
                    perDiscount = 0.15;
                }
                var totalPrice = 2500 + price;
                var discount = totalPrice - (perDiscount * totalPrice);
                var pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:F2}$");


            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                //Teracce
                if (package == "Gold")
                {

                    price = 750;
                    perDiscount = 0.1;


                }
                else if (package == "Normal")
                {
                    price = 500;
                    perDiscount = 0.05;

                }
                else if (package == "Platinum")
                {
                    price = 1000;
                    perDiscount = 0.15;
                }
                var totalPrice = 5000 + price;
                var discount = totalPrice - (perDiscount * totalPrice);
                var pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:F2}$");



            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                //Great Hall
                if (package == "Gold")
                {

                    price = 750;
                    perDiscount = 0.1;


                }
                else if (package == "Normal")
                {
                    price = 500;
                    perDiscount = 0.05;

                }
                else if (package == "Platinum")
                {
                    price = 1000;
                    perDiscount = 0.15;
                }
                var totalPrice = 7500 + price;
                var discount = totalPrice - (perDiscount * totalPrice);
                var pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:F2}$");

            }
            else
            {

                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
