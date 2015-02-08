using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class LostInTranslation
    {
        private static readonly Dictionary<char, int> _dictionary = new Dictionary<char, int>();
        private static readonly char[] _letters = { 'e', 't', 'a', 'o', 'i', 'n', 's', 'h', 'r', 'd', 'l', 'c', 'u', 'm', 'w', 'f', 'g', 'y', 'p', 'b', 'v', 'k', 'j', 'x', 'q', 'z' };
        //private static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        foreach (char c in line.Where(c => c != ' '))
        //        {
        //            if (_dictionary.ContainsKey(c))
        //                _dictionary[c]++;
        //            else
        //                _dictionary[c] = 1;
        //        }
        //        var t = _dictionary.OrderBy(x => x.Value);
        //        var ordered = t.Reverse().ToList();
        //        Dictionary<char, char> result = new Dictionary<char, char>(ordered.Count);
        //        for(int i = 0; i < ordered.Count; i++)
        //        {
        //            result.Add(ordered[i].Key, _letters[i]);
        //        }
        //        result.Add(' ',' ');
        //        string answer = line.Aggregate(string.Empty, (current, c) => current + result[c]);
        //        Console.WriteLine(answer);
        //    }
        //}
    }
}
