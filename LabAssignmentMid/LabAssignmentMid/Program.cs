using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("You are a minor.");
            else if (age <= 30)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are a senior.");
        }
    }
}
