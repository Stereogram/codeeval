using System.IO;
using System.Linq;

namespace codeeval.easy
{
    public class SlangFlavor
    {
        private static string[] slang =
        {
            ", yeah!"
            ,", this is crazy, I tell ya."
            ,", can U believe this?"
            ,", eh?"
            ,", aw yea."
            ,", yo."
            ,"? No way!"
            ,". Awesome!"
        };

        private static int i;
        private static bool next;
        private static string answer = string.Empty;

        //private static void Main(string[] args)
        //{
        //    foreach (char c in File.ReadAllText(args[0]))
        //        if (isEndPunc(c))
        //        {
        //            if (next)
        //            {
        //                answer += slang[i];
        //                i = i+1 > 7 ? 0 : i+1;
        //            }
        //            else
        //                answer += c;
        //            next = !next;
        //        }
        //        else
        //            answer += c;
        //    System.Console.WriteLine(answer);
        //}

        private static bool isEndPunc(char c)
        {
            return c == '.' || c == '?' || c == '!';
        }

    }
}
