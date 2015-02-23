using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class DecodeNumbers
    {
        private static readonly string[] _list =
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13",
            "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"
        }; 

        //private static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        Console.WriteLine(Split(line).Sum(x => Contains(x, _list)));
        //    }
        //}

        static int Contains(IEnumerable<string> a, IEnumerable<string> b)
        {
            return a.Any(s => !Contains(s, b)) ? 0 : 1;
        }

        static bool Contains(string a, IEnumerable<string> b)
        {
            return b.Any(s => s == a);
        }

        static IEnumerable<List<string>> Split(string input)
        {
            return Split(input, new List<string>());
        }

        static IEnumerable<List<string>> Split(string input, List<string> current)
        {
            if (input.Length == 0)
            {
                yield return current;
            }

            if (input.Length >= 1)
            {
                var copy = current.ToList();
                copy.Add(input.Substring(0, 1));
                foreach (var r in Split(input.Substring(1), copy))
                    yield return r;
            }

            if (input.Length >= 2)
            {
                var copy = current.ToList();
                copy.Add(input.Substring(0, 2));
                foreach (var r in Split(input.Substring(2), copy))
                    yield return r;
            }
        }


    }
}
