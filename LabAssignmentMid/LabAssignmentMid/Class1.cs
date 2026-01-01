using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentMid
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string menuInput;
            do
            {
                Console.WriteLine("**************** Menu ****************");
                Console.WriteLine("Press + to add two numbers");
                Console.WriteLine("Press - to substruct two numbers");
                Console.WriteLine("Press * to multiply two numbers");
                Console.WriteLine("Press / to devide two numbers");
                Console.WriteLine("Press    'Quit' to exit or cloes the program.");
                menuInput = Console.ReadLine();
                if (menuInput == "+" || menuInput == "-" || menuInput == "*" || menuInput == "/")
                {
                    Console.WriteLine("Please input two number for " + menuInput + " Operation.");
                    string strNumber1 = Console.ReadLine();
                    string strNumber2 = Console.ReadLine();
                    double number1 = double.Parse(strNumber1);
                    double number2 = double.Parse(strNumber2);
                    double result = 0;
                    if (menuInput == "+")
                    {
                        result = number1 + number2;
                    }
                    else if (menuInput == "-")
                    {
                        result = number1 - number2;
                    }
                    else if (menuInput == "*")
                    {
                        result = number1 * number2;
                    }
                    else if (menuInput == "/")
                    {
                        result = number1 / number2;
                    }
                    Console.WriteLine("Result: " + result);
                }

            } while (menuInput.ToLower() != "quit");
        }
    }
    
}
