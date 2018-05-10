using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfIngrediets = int.Parse(Console.ReadLine());
            var cheeseCalories = 0;
            var tomatoSauceCalories = 0;
            var salamiCalories = 0;
            var pepperCalories = 0;

            for (int i = 0; i < numberOfIngrediets; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                if (ingredients=="cheese")
                {
                    cheeseCalories += 500;

                }
                else if(ingredients=="tomato sauce")
                {
                    tomatoSauceCalories += 150;
                }
                else if (ingredients == "salami")
                {
                  salamiCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    pepperCalories += 50;
                }

            }

            var sumOfAllCalories = cheeseCalories + tomatoSauceCalories + salamiCalories + pepperCalories;
            Console.WriteLine($"Total calories: {sumOfAllCalories}");
        }
    }
}
