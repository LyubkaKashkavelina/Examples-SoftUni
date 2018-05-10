using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingredients = Console.ReadLine();
            int numberOfIngredients = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                numberOfIngredients++;
               
            }
            Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
        }
    }
}
