using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARS
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a Reverse Polish Notation expression: ");
                string rpnExpression = Console.ReadLine();
                Stack<string> infixStack = ConvertToInfix(rpnExpression);

                Console.WriteLine("Infix Notation:");
                foreach (string result in infixStack)
                {
                    Console.Write(result);
                }
                Console.Read();
            }

            static Stack<string> ConvertToInfix(string rpnExpression)
            {
                string[] tokens = RemoveSpacesAndSplit(rpnExpression);
                string lastElement = tokens[tokens.Length - 1];

                Stack<string> operandStack = new Stack<string>();
                string infixExpression;
                foreach (string token in tokens)
                {
                    if (IsOperator(token))
                    {
                        string operand2 = operandStack.Pop();
                        string operand1 = operandStack.Pop();
                        if (operand1.Contains("(") && operand2.Contains(")"))
                        {
                            infixExpression = $"{operand1} {token} {operand2}";
                        }


                        else
                        {
                            infixExpression = $"({operand1} {token} {operand2})";
                        }

                        operandStack.Push(infixExpression);
                    }
                    else
                    {
                        operandStack.Push(token);
                    }
                }

                return operandStack;
            }

            static bool IsOperator(string token)
            {
                return token == "+" || token == "-" || token == "*" || token == "/" || token == "x";
            }

            static string[] RemoveSpacesAndSplit(string input)
            {
                // Remove spaces from the input string
                string inputWithoutSpaces = input.Replace(" ", "");

                // Split the string into individual letters
                string[] letters = new string[inputWithoutSpaces.Length];
                for (int i = 0; i < inputWithoutSpaces.Length; i++)
                {
                    letters[i] = inputWithoutSpaces[i].ToString();
                }

                return letters;
            }
        }
    }
}