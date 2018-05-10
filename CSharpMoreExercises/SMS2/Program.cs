using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberofdigits = 0;
            var offsetNumber = 0;
            var letterIndex = 0;
            
            string letter = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string textMessageCharacter = Console.ReadLine();

                int lastDigit = int.Parse(textMessageCharacter[0].ToString());
                // while (Math.Abs(textMessageCharacter) > 1)
                //{

                //   textMessageCharacter = textMessageCharacter / 10;
                // numberofdigits++;


                //}
                //Console.WriteLine("Number of digits: {0}", textMessageCharacter.Length);
                // numberofdigits = 0;


                //Console.WriteLine(lastDigit);


                if (lastDigit == 8 || lastDigit == 9)
                {
                    offsetNumber = ((lastDigit - 2) * 3) + 1;
                }
                else
                {
                    offsetNumber = (lastDigit - 2) * 3;
                }
                //Console.WriteLine("Offsetnumber: {0}", offsetNumber);
                //Console.WriteLine("Last digit: {0}", lastDigit);

                letterIndex = offsetNumber + textMessageCharacter.Length - 1;
                //Console.WriteLine(letterIndex);
                if (lastDigit == 0)
                {
                    letter += " ";
                }
                else
                {
                    letter += (char)(letterIndex + 97);
                   
                }
               // Console.WriteLine("Letter: {0}", letter);
            }
            Console.WriteLine(letter);

            // Console.WriteLine("Number of digits: {0}", numberofdigits);

            // Console.WriteLine(lastDigit);

            //Console.WriteLine(letter);
            // Console.WriteLine(numberofdigits);
        }
    }
}
