using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int rounds = 0;


            for (int i = 1; ; i++)
            {
               
                if(i%2==0)
                {
                   
                    //Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth-goshoDamage}.");
                   peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                       break;
                      
                    }
                    else
                    {
                       
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                       

                    }


                }
                else
                {
                   
                    //Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth - peshoDamage}.");
                   goshoHealth -=  peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    else
                    {
                      
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
              

            }
           
           
        }
    }
}
