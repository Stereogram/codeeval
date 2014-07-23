using System;
using System.IO;
using System.Linq;

namespace codeeval.easy
{
    public class FibonacciSeries
    {
        //static void Main(string[] args)
        //{
        //    foreach (int n in File.ReadAllLines(args[0]).Select(int.Parse))
        //    {
        //        Console.WriteLine(F(n));
        //    }
        //}

        private static double F(int n)
        {
            if (n < 0)
                return -1;

            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            int int1 = 1;
            int int2 = 1;

            int fib = 0;

            //start from n==3
            for (int i = 1; i <= n - 2; i++)
            {
                fib = int1 + int2;
                //swap the values out:
                int2 = int1;
                int1 = fib;
            }

            return fib;
        }
    }
}
