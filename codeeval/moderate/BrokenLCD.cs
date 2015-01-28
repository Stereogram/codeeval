using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codeeval.moderate
{
    public class BrokenLCD
    {
        private static Dictionary<char, string> numbers = new Dictionary<char, string>()
        {
            {'0', "11111100"},
            {'1', "01100000"},
            {'2', "11011010"},
            {'3', "11110010"},
            {'4', "01100110"},
            {'5', "10110110"},
            {'6', "10111110"},
            {'7', "11100000"},
            {'8', "11111110"},
            {'9', "11110110"}
        };

        //private static void Main(string[] args)
        //{
        //    foreach (var line in File.ReadAllLines(args[0]))
        //    {
        //        string[] binaryStrings = line.Split(';')[0].Split(' ');
        //        string number = line.Split(';')[1];
        //        List<string> testNumbers = new List<string>(binaryStrings.Length);
        //        char p = number.First();
        //        bool b = false;
        //        foreach (char c in number)
        //        {
        //            if (c == '.')
        //            {
        //                b = true;
        //                continue;
        //            }
        //            if (b)
        //            {
        //                testNumbers.Remove(testNumbers.Last());
        //                testNumbers.Add(AddDecimal(p));
        //                testNumbers.Add(numbers[c]);
        //                b = false;
        //            }
        //            else
        //                testNumbers.Add(numbers[c]);
        //            p = c;
        //        }
        //        bool test = false;
        //        //for(int i = 0; i < testNumbers.Count; i++)
        //        //{
        //        //    Console.Write(numbers.FirstOrDefault(x => x.Value == testNumbers[i]).Key);
        //        //}
        //        for (int i = testNumbers.Count-1, j = binaryStrings.Length-1; i >= 0; i--, j--)
        //        {
        //            if (!Compare(binaryStrings[j], testNumbers[i]))
        //            {
        //                test = true;
        //                Console.WriteLine(binaryStrings[j] +" | " + testNumbers[i]);
        //                break;
        //            }
        //        }
        //        Console.WriteLine(test ? "1" : "0");
        //    }
        //}

        private static string AddDecimal(char c)
        {
            char[] s = numbers[c].ToCharArray();
            s[7] = '1';
            return new string(s);
        }

        private static bool Compare(string a, string b)
        {
            bool any = true;
            int i = 0;
            foreach (char t in a)
            {
                if (!toBool(t) && toBool(b[i++]))
                {
                    any = false;
                    break;
                }
            }
            return any;
        }

        private static bool toBool(char c)
        {
            return c == '1';
        }

    }
}
