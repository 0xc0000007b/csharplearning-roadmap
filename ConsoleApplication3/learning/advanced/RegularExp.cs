using System;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleApplication3
{
    public class RegularExp
    {
        private string line = "287et3ygrueyufygvngjkdflkrvlgkjhkhvjklk:ijdhfugr4473875hcjflkvjj";
        private static string site = String.Empty;
        public void FindRegexMatches()
        {
            MatchCollection match = Regex.Matches(line, "[A-z]");
            Console.WriteLine(match.Count.ToString() + " matches by [A-z] mask");
            MatchCollection matchN = Regex.Matches(line, "[0-:]");
            Console.WriteLine(matchN.Count.ToString() + " matches by [1-:] mask");
        }

        
        
    }
}