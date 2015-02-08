using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.hard
{
    public class ASCIIDecryption
    {
        private static void Main(string[] args)
        {
            foreach (var line in File.ReadAllLines(args[0]).Select(x => x.Split('|')))
            {
                int num = int.Parse(line[0]);
                char end = line[1][1];
                int[] msg = line[2].TrimStart().Split(' ').Select(int.Parse).ToArray();
                var test = ConstructList(msg);
                var word = test.GroupBy(x => x).Where(g => g.Count() > 1 && g.Key.Length == num).Select(g => g.Key).ToList();
                int diff = (int) word.First().Last() - (int) end;
                Console.WriteLine(UnEncrypt(msg, diff));
            }
        }

        private static List<string> ConstructList(int[] msg)
        {
            List<string> words = new List<string>();
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int s in msg)
            {
                if (freq.ContainsKey(s))
                    freq[s]++;
                else
                    freq[s] = 1;
            }
            char space = (char)freq.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            string word = string.Empty;
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

        private static string UnEncrypt(int[] msg, int key)
        {
            return msg.Aggregate(string.Empty, (current, i) => current + (char) (i - key));
        }
    }
}
