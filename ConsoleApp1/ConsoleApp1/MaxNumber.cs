using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            int[][] marks = {
            new int[] {80, 90},
            new int[] {70, 85, 90},
            new int[] {60, 75}
        };

            for (int i = 0; i < marks.Length; i++)
            {
                int max = marks[i][0];
                for (int j = 1; j < marks[i].Length; j++)
                {
                    if (marks[i][j] > max)
                        max = marks[i][j];
                }
                Console.WriteLine("Student " + (i + 1) + " Max Mark = " + max);
            }
        }
    }
}
