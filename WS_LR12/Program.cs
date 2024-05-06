using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "qw234.55.7.8eqwweqwq99999.23.99.0 qweqweqwqwwq";
        Regex regex = new Regex(@"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)");
        MatchCollection matches = regex.Matches(str);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}