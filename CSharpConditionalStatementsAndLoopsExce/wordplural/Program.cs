using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordplural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            bool endsInY = word.EndsWith("y");
            bool endsInO = word.EndsWith("o");
            bool endsInCH = word.EndsWith("ch");
            bool endsInS = word.EndsWith("s");
            bool endsInSh = word.EndsWith("sh");
            bool endsInX = word.EndsWith("x");
            bool endsInZ = word.EndsWith("z");


            if (endsInY)
            {
                
                var newWord = word.Remove(word.Length-1);
                Console.WriteLine(newWord+"ies");

            }
            else if(endsInO||endsInCH||endsInS||endsInSh||endsInX||endsInZ)
            {
                
                Console.WriteLine(word + "es");
            }
            else
            {

                Console.WriteLine(word + "s");
            }

        }
    }
}
