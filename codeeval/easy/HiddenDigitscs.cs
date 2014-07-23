using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace codeeval.easy
{
    public class HiddenDigitscs
    {
        private static readonly Dictionary<char, char> _dictionary = new Dictionary<char, char>()
        {
            {'a', '0'},
            {'b', '1'},
            {'c', '2'},
            {'d', '3'},
            {'e', '4'},
            {'f', '5'},
            {'g', '6'},
            {'h', '7'},
            {'i', '8'},
            {'j', '9'}
        };

        //static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        Regex r = new Regex("[^a-j0-9]");
        //        var t = r.Replace(line,"");
        //        foreach (char c in t.Where(c => _dictionary.ContainsKey(c)))
        //        {
        //            t = t.Replace(c,_dictionary[c]);
        //        }
        //        Console.WriteLine(t == string.Empty ? "NONE" : t);
        //    }
        //}
    }
}
