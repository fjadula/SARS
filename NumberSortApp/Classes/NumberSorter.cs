using SARS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARS.Classes
{
    class NumberSorter : INumberProcessor
    {
        private List<int> numbers;

        public NumberSorter()
        {
            numbers = new List<int>();
        }

        public bool AcceptInput(string input)
        {
            bool validInput = true;  // Assume input is valid by default
            string[] inputArray = input.Split(',');

            foreach (string item in inputArray)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                   
                }
                else
                {
                    Console.WriteLine("Error: Input should only contain numbers.");
                    validInput = false;  
                    break;  
                }
            }
            return validInput;  
        }

        public void ProcessAndPrint()
        {
            numbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine("Sorted numbers (highest to lowest):");
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
