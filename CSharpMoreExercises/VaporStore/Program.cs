using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            var initialBalance = balance;
            var currentPrice = 0.0;
            string gameTitle = String.Empty;

            while (game != "Game Time")
            {


                switch (game)
                {
                    case "OutFall 4":
                        //if (balance < 39.99)
                        //{
                        //Console.WriteLine("Too expensive");
                        //game = Console.ReadLine();
                        //}
                        //else
                        // {
                        // Console.WriteLine($"Bought {game}");
                        // balance -= 39.99;
                        // }
                        //game = Console.ReadLine();

                        currentPrice = 39.99;
                        gameTitle = "OutFall 4";
                        break;
                    case "CS: OG":
                        //if (balance < 15.99)
                        // {
                        //Console.WriteLine("Too expensive");
                        //game = Console.ReadLine();
                        // }
                        // else
                        // {
                        //Console.WriteLine($"Bought {game}");
                        // balance -= 15.99;
                        //}
                        // game = Console.ReadLine();
                        currentPrice = 15.99;
                        gameTitle = "CS: OG";
                        break;
                    case "Zplinter Zell":
                        //if (balance < 19.99)
                        //{
                        //    //Console.WriteLine("Too expensive");
                        //    //game = Console.ReadLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"Bought {game}");
                        //    balance -= 19.99;
                        //}
                        // game = Console.ReadLine();
                        currentPrice = 19.99;
                        gameTitle = "Zplinter Zell";
                        break;
                    case "Honored 2":
                        //if (balance < 59.99)
                        //{
                        //    Console.WriteLine("Too expensive");
                        //    //game = Console.ReadLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"Bought {game}");
                        //    balance -= 59.99;
                        //}
                        // game = Console.ReadLine();
                        currentPrice = 59.99;
                        gameTitle = "Honored 2";
                        break;
                    case "RoverWatch":
                        //if (balance < 29.99)
                        //{
                        //    //Console.WriteLine("Too expensive");
                        //    game = Console.ReadLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"Bought {game}");
                        //    balance -= 29.99;
                        //}
                        //game = Console.ReadLine();
                        currentPrice = 29.99;
                        gameTitle = "RoverWatch";
                        break;
                    case "RoverWatch Origins Edition":
                        //if (balance < 39.99)
                        //{
                        //    Console.WriteLine("Too expensive");
                        //   // game = Console.ReadLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"Bought {game}");
                        //    balance -= 39.99;
                        //}
                        // game = Console.ReadLine();
                        currentPrice = 39.99;
                        gameTitle = "RoverWatch Origins Edition";
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        break;
                }
                if (currentPrice > balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    balance -= currentPrice;
                    Console.WriteLine($"Bought {gameTitle}");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            var dsfhjdkf = initialBalance - balance;
           Console.WriteLine($"Total spent: ${(dsfhjdkf):F2}. Remaining: ${(balance):F2}");
        }
        
    }
}
