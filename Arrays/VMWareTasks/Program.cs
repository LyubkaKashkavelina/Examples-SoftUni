using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMWareTasks
{
    class Program
    {
        static public int FindSum(string text)
        {
            string temp = string.Empty;
           
            int sum = 0;
            for(int i = 0;i<text.Length;i++)
            {

                if (Char.IsDigit(text[i]))
                {
                    temp += text[i];

                }
                else
                {
                    if(temp!=string.Empty)
                    {
                        sum += int.Parse(temp);
                        temp = string.Empty;
                    }
                   
                }
                
            }
            if (temp != string.Empty)
            {
                sum += int.Parse(temp);

            }

            return sum;
        }
        static void Main(string[] args)
        {
            string textToInsert = Console.ReadLine();
            var sum = FindSum(textToInsert);
            Console.WriteLine(sum);

        }
    }
}
