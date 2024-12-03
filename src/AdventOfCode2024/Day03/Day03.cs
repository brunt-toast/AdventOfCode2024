using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03
{
    public class Day03
    {
        private static string GetInput()
        {
            string path = Path.Join(".", "Day03", "input.txt");
            return File.ReadAllText(path);
        }

        public static int Part1()
        {
            string input = GetInput();
            Regex instructionRegex = new(@"mul\((\d{1,3}),(\d{1,3})\)");
            MatchCollection matches = instructionRegex.Matches(input);
            int runningTotal = 0;
            foreach (Match match in matches)
            {
                int num1 = int.Parse(match.Groups[1].Value);
                int num2 = int.Parse(match.Groups[2].Value);
                runningTotal += num1 * num2;
            }

            return runningTotal;
        }
    }
}