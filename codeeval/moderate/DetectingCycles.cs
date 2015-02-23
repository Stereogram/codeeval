using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class DetectingCycles
    {
        private static void Main(string[] args)
        {
            foreach (var input in File.ReadAllLines(args[0]).Select(x => x.Split(' ')))
            {
                //set can only contain unique elements.
                HashSet<string> set = new HashSet<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    //if we encounter a duplicate AKA a cycle.
                    if (!set.Add(input[i]))
                    {
                        //index of first occurrence of duplicate.
                        var a = Array.IndexOf(input, input[i]);
                        //get the sub array from first duplicate element to current duplicate element (but not it).
                        var test = input.SubArray2(a, i - a);
                        Console.WriteLine(string.Join(" ", test));
                        break;
                    }
                }
            }
        }
    }
    public static class Extension
    {
        //because apparently [].SubArray is a .net version >4.0 thing.
        public static T[] SubArray2<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }

}
