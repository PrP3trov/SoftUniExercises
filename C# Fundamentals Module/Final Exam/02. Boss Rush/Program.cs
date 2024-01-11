using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02._Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patern = @"\|(?<name>[A-Z]{4,})\|:#(?<tiltle>[A-z]+ [A-z]+)#";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int valid = Regex.Matches(input, patern).Count();
                if (valid == 1)
                {
                    foreach (Match match in Regex.Matches(input, patern))
                    {
                        Console.WriteLine($"{match.Groups["name"].Value}, The {match.Groups["tiltle"].Value}");
                        Console.WriteLine($">> Strength: {match.Groups["name"].Length}");
                        Console.WriteLine($">> Armor: {match.Groups["tiltle"].Length}");
                    }
                }
                else Console.WriteLine("Access denied!");
            }
        }
    }
}