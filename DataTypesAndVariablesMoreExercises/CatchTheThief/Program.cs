using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            short n = short.Parse(Console.ReadLine());
            long maxValue = 0L;
            long thiefsID = long.MinValue;
            switch(numeralType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if(id>thiefsID&&id<=maxValue)
                {
                    thiefsID = id;
                }

            }
            Console.WriteLine(thiefsID);
        }
    }
}
