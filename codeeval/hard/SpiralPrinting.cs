using System;
using System.IO;
using System.Linq;

namespace codeeval.hard
{
    public class SpiralPrinting
    {
        static void Main(string[] args)
        {
            foreach (var result in File.ReadAllLines(args[0]).Select(x => x.Split(';')))
            {
                int n = int.Parse(result[0]);
                int m = int.Parse(result[1]);
                string[] arr = result[2].Trim().Split(' ');
                string[,] map = new string[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        map[i, j] = arr[(i * m) + j];
                
                    PrintSpiral(map, m, n);
                
                
            }
        }

        //http://stackoverflow.com/questions/726756/print-two-dimensional-array-in-spiral-order
        // function to print the top-right peel of the matrix and 
        // recursively call the print bottom-left on the submatrix.
        private static void PrintTopRight(string[,] a, int x1, int y1, int x2, int y2)
        {
            // print values in the row.
            for (int i = x1; i <= x2; i++)
            {
                Console.Write(a[y1, i] + " ");
            }

            // print values in the column.
            for (int j = y1 + 1; j <= y2; j++)
            {
                Console.Write(a[j, x2] + " ");
            }

            // see if more layers need to be printed.
            if (x2 - x1 > 0)
            {
                // if yes recursively call the function to 
                // print the bottom left of the sub matrix.
                PrintBottomLeft(a, x1, y1 + 1, x2 - 1, y2);
            }
        }

        // function to print the bottom-left peel of the matrix and 
        // recursively call the print top-right on the submatrix.
        private static void PrintBottomLeft(string[,] a, int x1, int y1, int x2, int y2)
        {
            // print the values in the row in reverse order.
            for (int i = x2; i >= x1; i--)
            {
                Console.Write(a[y2, i] + " ");
            }

            // print the values in the col in reverse order.
            for (int j = y2 - 1; j >= y1; j--)
            {
                Console.Write(a[j, x1] + " ");
            }

            // see if more layers need to be printed.
            if (x2 - x1 > 0)
            {
                // if yes recursively call the function to 
                // print the top right of the sub matrix.
                PrintTopRight(a, x1 + 1, y1, x2, y2 - 1);
            }
        }

        public static void PrintSpiral(string[,] arr, int col, int row)
        {
            PrintTopRight(arr, 0, 0, col - 1, row - 1);
            Console.WriteLine();
        }

    }
}
