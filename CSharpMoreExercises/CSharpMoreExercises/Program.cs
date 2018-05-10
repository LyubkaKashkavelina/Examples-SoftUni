using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    
    
       

namespace xxx
    {
        class Program
        {
            static void Main(string[] args)
            {
                int height = int.Parse(Console.ReadLine());

                for (int i = 0; i < (height - 1) / 2; i++)
                {
                    // while (height > 2 * i)
                    {
                        Console.WriteLine($"{new string(' ', i)}x{new string(' ', height - 2 - (2 * i))}x{new string(' ', i)}");
                    }
                }
                Console.WriteLine($"{new string(' ', (height - 1) / 2)}x{new string(' ', (height - 1) / 2)}");

                for (int i = ((height - 1) / 2); i > 0; i--)
                {
                    // while (height > 2 * i)
                    {
                        Console.WriteLine($"{new string(' ', i - 1)}x{new string(' ', height - (2 * i))}x{new string(' ', i - 1)}");
                    }
                }

            }
        }
    }


   

