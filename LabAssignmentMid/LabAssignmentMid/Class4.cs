using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentMid
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            string word;
            int count = 0;

            while (true)
            {
                Console.Write("Enter a word (type 'exit' to stop): ");
                word = Console.ReadLine();
                if (word.ToLower() == "exit")
                    break;
                count++;
            }

            Console.WriteLine("Total words entered: " + count);
        }
    }
}
