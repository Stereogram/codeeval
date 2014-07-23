using System;
using System.IO;
using System.Linq;

namespace codeeval.easy
{
    public class SplitTheNumber
    {
        //static void Main(string[] args)
        //{
        //    foreach (var result in File.ReadAllLines(args[0]).Select(x => x.Split(' ')))
        //    {
        //        var nums = result[0].ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
        //        bool plus = result[1].Contains('+');
        //        var eq = plus ? result[1].Split('+') : result[1].Split('-');
        //        var p1 = int.Parse(string.Join("",nums.Take(eq[0].Length)));
        //        var p2 = int.Parse(string.Join("",nums.Skip(eq[0].Length)));
        //        Console.WriteLine(plus?p1+p2:p1-p2);
        //    }
        //}
    }
}
