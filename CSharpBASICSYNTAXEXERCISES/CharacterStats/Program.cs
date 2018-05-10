using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterName = Console.ReadLine();
            var linesHealth = int.Parse(Console.ReadLine());
            var sizeHealth = int.Parse(Console.ReadLine());
            var linesEnergy = int.Parse(Console.ReadLine());
            var sizeEnergy = int.Parse(Console.ReadLine());

            var dothsHealth = sizeHealth - linesHealth;
            var dothsEnergy = sizeEnergy - linesEnergy;

            Console.WriteLine($"Name: {characterName} ");
            Console.WriteLine($"Health: |{new string('|',linesHealth)}{new string('.',dothsHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', linesEnergy)}{new string('.', dothsEnergy)}|");
            


        }
    }
}
