using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.easy
{
    public class HappyNumbers
    {
        //static void Main(string[] args)
        //{
        //    foreach (var result in File.ReadAllLines(args[0]).Select(x => x.ToCharArray()))
        //    {
        //        var nums = CharArrToIntArr(result);
        //        bool yes = false;
        //        int number;
        //        for (int i = 0; i < 100; i++)
        //        {
        //            number = SumOfSquares(nums);
        //            if (number == 1)
        //            {
        //                yes = true;
        //                break;
        //            }
        //            nums = CharArrToIntArr(number.ToString());
        //        }
        //        Console.WriteLine(yes?"1":"0");
        //    }
        //}

        private static int SumOfSquares(IEnumerable<int> ns)
        {
            return ns.Aggregate(0, (sum, i) => sum + (i*i));
        }

        private static IEnumerable<int> CharArrToIntArr(IEnumerable<char> a)
        {
            return a.Select(c =>int.Parse(c.ToString()));
        }

    }
}
