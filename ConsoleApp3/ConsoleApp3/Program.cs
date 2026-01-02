using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] b = { { 2, 3, 5, 7 },
             { 4, 6, 1, 8 },
             { 9, 0, 4, 3 } };

            int rows = b.GetLength(0);
            int cols = b.GetLength(1);
            int[,] outMatrix = new int[rows, cols];

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    int acc = 0;
                    for (int k = 0; k < cols; ++k)
                        acc += b[r, k] * b[k, c];
                    outMatrix[r, c] = acc;
                }
            }

            Console.Write(outMatrix[1, 2]);
        }
            }
    }

        

    
