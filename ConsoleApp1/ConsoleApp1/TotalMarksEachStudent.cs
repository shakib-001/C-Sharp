using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TotalMarksEachStudent
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
                int total = 0;
                for (int j = 0; j < marks[i].Length; j++)
                {
                    total += marks[i][j];
                }
                Console.WriteLine("Student" + (i + 1) + " Total Marks = " + total);
                int average = total / marks[i].Length;
                Console.WriteLine("Average = " + average);

            }
        }
    }
}