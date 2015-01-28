using System;
using System.IO;

namespace codeeval.easy
{
    public class QueryBoard
    {
        private static readonly byte [,] _board = new byte[256,256];

        //private static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        var arg = line.Split(' ');
        //        string command = arg[0];
        //        byte a = byte.Parse(arg[1]);
        //        byte b;
        //        switch (command)
        //        {
        //            case "SetCol":
        //                b = byte.Parse(arg[2]);
        //                SetCol(a,b);
        //                break;
        //            case "SetRow":
        //                b = byte.Parse(arg[2]);
        //                SetRow(a,b);
        //                break;
        //            case "QueryCol":
        //                QueryCol(a);
        //                break;
        //            case "QueryRow":
        //                QueryRow(a);
        //                break;
        //        }
        //    }
        //}

        private static void SetCol(int j, byte x)
        {
            for (int i = 0; i < 256; i++)
            {
                _board[j, i] = x;
            }
        }

        private static void SetRow(int j, byte x)
        {
            for (int i = 0; i < 256; i++)
            {
                _board[i, j] = x;
            }
        }

        private static void QueryCol(int j)
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += _board[j, i];
            }
            Console.WriteLine(sum);
        }

        private static void QueryRow(int j)
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += _board[i, j];
            }
            Console.WriteLine(sum);
        }
    }
}
