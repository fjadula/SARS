using SARS.Classes;
using SARS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of comma-separated numbers:");
            string input = Console.ReadLine();
            bool result;

            INumberProcessor numberProcessor = new NumberSorter();
            result = numberProcessor.AcceptInput(input);
            if (result)
            {
                numberProcessor.ProcessAndPrint();
            }
            Console.Read();
        }
    }
}