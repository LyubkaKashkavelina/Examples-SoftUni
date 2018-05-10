using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingAndTroubleshootingCode
{
    class Program
    {
        static void PrintHeder()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrihtFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeder();
            PrintBody();
            PrihtFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
