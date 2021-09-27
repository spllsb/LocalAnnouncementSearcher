using System.Text.RegularExpressions;

namespace src.Extensions
{
    public static class StringExtensions
    {
        public static string ParseOlxHtmlDocToJsonStringFormat(this string input)
        {
            string pattern = @"window.__PRERENDERED_STATE__\S*=\S*(.*)";
            MatchCollection result = Regex.Matches(input, pattern);

            string aaa = result[0].Value.Remove(0, 31);
            string aaaa = aaa.Remove(aaa.Length-2, 2);
            string zz = aaaa.Replace("\\\"","\'");
            return zz;
        }
    }
}