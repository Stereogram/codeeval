using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.easy
{
    public class MorseCode
    {
        #region alphabet
        private static readonly Dictionary<string, char> _dictionary = new Dictionary<string, char>()
        {
            {".-", 'a'},
            {"-...", 'b'},
            {"-.-.", 'c'},
            {"-..", 'd'},
            {".", 'e'},
            {"..-.", 'f'},
            {"--.", 'g'},
            {"....", 'h'},
            {"..", 'i'},
            {".---", 'j'},
            {"-.-", 'k'},
            {".-..", 'l'},
            {"--", 'm'},
            {"-.", 'n'},
            {"---", 'o'},
            {".--.", 'p'},
            {"--.-", 'q'},
            {".-.", 'r'},
            {"...", 's'},
            {"-", 't'},
            {"..-", 'u'},
            {"...-", 'v'},
            {".--", 'w'},
            {"-..-", 'x'},
            {"-.--", 'y'},
            {"--..", 'z'},
            {"-----", '0'},
            {".----", '1'},
            {"..---", '2'},
            {"...--", '3'},
            {"....-", '4'},
            {".....", '5'},
            {"-....", '6'},
            {"--...", '7'},
            {"---..", '8'},
            {"----.", '9'}
        };
        #endregion
        //static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        var words = line.Replace("  ", "|").Split('|');
        //        string word = string.Empty;
        //        foreach (var s in words.Select(x => x.Split(' ')))
        //        {
        //            word = s.Aggregate(word, (current, c) => current + _dictionary[c]);
        //            word += ' ';
        //        }
        //        Console.WriteLine(word.ToUpper());
        //    }
        //}
    }
}
