using System;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class ReverseAndAdd
    {
        //static void Main(string[] args)
        //{
        //    foreach (var result in File.ReadAllLines(args[0]).Select(int.Parse))
        //    {
        //        double sum = result;
        //        int i = 0;
        //        while (!IsPalim(sum))
        //        {
        //            sum += double.Parse(new string(sum.ToString().Reverse().ToArray()));
        //            i++;
        //        }
        //        Console.WriteLine("{0} {1}",i,sum);
        //    }
        //}

        private static bool IsPalim(double a)
        {
            return new string(a.ToString().Reverse().ToArray()) == a.ToString();
        }
    }
}
