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
        //    foreach (var result in File.ReadAllLines(args[0]).Select(x => x.Split(';')))
        //    {
        //        var list0 = result[0].ToList().AllCombinations().Select(x => new string(x.ToArray()));
        //        var list1 = result[1].ToList().AllCombinations().Select(x => new string(x.ToArray()));
        //        foreach (var word in list0.Where(list1.Contains))
        //        {
        //            Console.WriteLine(word.ToArray());
        //            break;
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