using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace codeeval.easy
{
    public class BeautifulStrings
    {
        //static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]).Select(x => x.ToLower()))
        //    {
        //        Regex r = new Regex("[^a-z]");
        //        var result = r.Replace(line, "");
        //        Dictionary<char, int> alpha = new Dictionary<char, int>();
        //        foreach (char c in result)
        //        {
        //            if (alpha.ContainsKey(c))
        //                alpha[c]++;
        //            else
        //                alpha.Add(c, 1);
        //        }
        //        var myList = alpha.ToList();
        //        myList.Sort((a, b) => b.Value.CompareTo(a.Value));
        //        int sum = 0;
        //        for (int i = 26, j = 0; j < myList.Count; i--, j++)
        //        {
        //            sum += i * myList[j].Value;
        //        }
        //        Console.WriteLine(sum);
        //    }
        //}
    }
}
