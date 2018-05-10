using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItemsToBuy = int.Parse(Console.ReadLine());
            double subtotal = 0.0;
            int itemCount = 0;
            double itemPrice = 0.0;
            double totalPrice = 0.0;

            for (int i = 1; i <= numberOfItemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());

                if(itemCount>1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                totalPrice = itemCount * itemPrice;
                subtotal += totalPrice;

                //if(budget>subtotal)
                //{
                //    Console.WriteLine($"Money left: ${(budget-subtotal):F2}");
                //}
                //else
                //{
                //    Console.WriteLine($"Not enough. We need ${subtotal-budget} more.");
                //}
            }
            
            Console.WriteLine($"Subtotal: ${(subtotal):F2}");
            
            if (budget >= subtotal)
            {
                Console.WriteLine($"Money left: ${(budget - subtotal):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subtotal - budget):F2} more.");
            }
        }
    }
}
