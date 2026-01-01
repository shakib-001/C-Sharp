using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = {
            new int[] {80, 90},
            new int[] {70, 85, 90},
            new int[] {60, 75}
        };

            int sum = 0, count = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    sum += marks[i][j];
                    count++;

                }
            }
            Console.WriteLine(sum);

        }
    }
}
