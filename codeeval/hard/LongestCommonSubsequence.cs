using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.hard
{
    public class LongestCommonSubsequence
    {
        //private static void Main(string[] args)
        //{
        //    foreach (var result in File.ReadAllLines(args[0]).Select(x => x.Split(';')).ToList())
        //    {
        //        for (int i = result[0].Length; i >= 0; i--)
        //        {
        //            var list0 = result[0];
        //            var list1 = result[1];
        //            var common = list0.Intersect(list1);
        //            string s0 = list0.Where(common.Contains).Aggregate(string.Empty, (current, c) => current + c);
        //            string s1 = list1.Where(common.Contains).Aggregate(string.Empty, (current, c) => current + c);
        //            var test0 = s0.Combinations(i).Select(x => new string(x.ToArray()));
        //            var test1 = s1.Combinations(i).Select(x => new string(x.ToArray()));
        //            var inter = test0.Intersect(test1);
        //            if (inter.Any())
        //            {
        //                Console.WriteLine(inter.First());
        //                break;
        //            }
        //        }
        //    }
        //}
    }

    public static class Ext
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> source, int n)
        {
            if (n == 0)
                yield return Enumerable.Empty<T>();

            int count = 1;
            foreach (T item in source)
            {
                foreach (var innerSequence in source.Skip(count).Combinations(n - 1))
                {
                    yield return new T[] {item}.Concat(innerSequence);
                }
                count++;
            }
        }

        public static IEnumerable<IEnumerable<T>> AllCombinations<T>(this IList<T> source)
        {
            IEnumerable<IEnumerable<T>> output = Enumerable.Empty<IEnumerable<T>>();
            for (int i = source.Count; i >= 0; i--)
            {
                output = output.Concat(source.Combinations(i));
            }
            return output;
        }
    }

}