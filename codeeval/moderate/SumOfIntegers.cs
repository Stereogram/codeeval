using System;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class SumOfIntegers
    {
        //static void Main(string[] args)
        //{
        //    foreach (int max in from result in File.ReadAllLines(args[0]).Select(x => x.Split(','))
        //        select result.Select(int.Parse).ToArray()
        //        into arr
        //        select (from i in Enumerable.Range(0, arr.Length)
        //            from j in Enumerable.Range(0, arr.Length - i + 1)
        //            where j >= 2
        //            select arr.SubArray(i, j))
        //        into query
        //        select query.Select(nums => nums.Sum()).Concat(new[] {0}).Max())
        //    {
        //        Console.WriteLine(max);
        //    }
        //}
    }

    public static class Ext
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }

}
