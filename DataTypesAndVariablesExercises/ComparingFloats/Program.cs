using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double firstNumber = double.Parse(Console.ReadLine());
            double scondNumber = double.Parse(Console.ReadLine());

            var razlika = Math.Abs(firstNumber - scondNumber);
            if(razlika>eps||razlika==eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            
        }
    }
}
