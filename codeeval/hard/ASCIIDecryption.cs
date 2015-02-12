using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.hard
{
    public class ASCIIDecryption
    {
        //private static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]).Select(x => x.Split('|')))
        //    {
        //        int num = int.Parse(line[0]);
        //        //splitting on '|' will make line[1] = " x "
        //        char end = line[1][1];
        //        //trimstart to get rid of leading empty element when we split on ' '
        //        int[] msg = line[2].TrimStart().Split(' ').Select(int.Parse).ToArray();
        //        var test = ConstructList(msg);
        //        //find the duplicate word of length "num".
        //        var word = test.GroupBy(x => x).Where(g => g.Count() == 2 && g.Key.Length == num).Select(g => g.Key).ToList();
        //        //create key by subracting the character we have with the character it should be. 
        //        int diff = (int) word.First().Last() - (int) end;
        //        Console.WriteLine(UnEncrypt(msg, diff));
        //    }
        //}

        private static IEnumerable<string> ConstructList(int[] msg)
        {
            List<string> words = new List<string>();
            Dictionary<int, int> freq = new Dictionary<int, int>();
            //calculate which character is the most frequent.
            foreach (int s in msg)
            {
                if (freq.ContainsKey(s))
                    freq[s]++;
                else
                    freq[s] = 1;
            }
            //*assumption* most frequent character will be the space.
            char space = (char)freq.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            string word = string.Empty;
            //construct list of words, separated by the 'space'.
            foreach (char letter in msg.Select(s => (char)s))
            {
                if (letter == space)
                {
                    words.Add(word);
                    word = string.Empty;
                    continue;
                }
                word += letter;
            }
            words.Add(word);
            return words;
        }

        private static string UnEncrypt(IEnumerable<int> msg, int key)
        {
            //create final string by subtracting key from our message.
            return msg.Aggregate(string.Empty, (current, i) => current + (char) (i - key));
        }
    }
}
