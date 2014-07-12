using System;
using System.IO;

namespace codeeval.easy
{
    public class LettercasePercentageRatio
    {
        private static void Main(string[] args)
        {
            foreach (var line in File.ReadAllLines(args[0]))
            {
                double u = 0;
                double l = 0;
                foreach (char c in line)
                {
                    if (char.IsUpper(c))
                        u++;
                    else
                        l++;
                }
                var up = (u / (u + l)) * 100;
                var lp = (l / (u + l)) * 100;
                Console.WriteLine("lowercase: {0} uppercase: {1}", lp.ToString("0.00"), up.ToString("0.00"));
            }
        }
    }
}
