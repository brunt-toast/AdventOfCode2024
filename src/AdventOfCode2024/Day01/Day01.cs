namespace AdventOfCode2024.Day01
{
    public class Day01
    {
        private static IEnumerable<string> GetInput()
        {
            string path = Path.Join(".", "Day01", "input.txt");
            return File.ReadLines(path);
        }

        public static int Part1()
        {
            IEnumerable<string> input = GetInput();

            // split the input into 2 lists 
            List<int> left = [];
            List<int> right = [];
            foreach (string line in input)
            {
                Console.WriteLine();
                left.Add(int.Parse(line.Split("   ")[0]));
                right.Add(int.Parse(line.Split("   ")[1]));
            }

            // order the lists in place 
            left.Sort();
            right.Sort();

            // find the diffs 
            List<int> diffs = [];
            for (int i = 0; i < left.Count; i++)
            {
                diffs.Add(Math.Abs(left[i] - right[i]));
            }

            // sum them
            int ret = diffs.Sum();
            Console.WriteLine(ret);

            return ret;
        }

        public static int Part2()
        {
            IEnumerable<string> input = GetInput();

            List<int> left = [];
            List<int> right = [];
            foreach (string line in input)
            {
                Console.WriteLine();
                left.Add(int.Parse(line.Split("   ")[0]));
                right.Add(int.Parse(line.Split("   ")[1]));
            }

            left = left.Distinct().ToList();
            List<int> similarityScores = [];
            foreach (int i in left)
            {
                similarityScores.Add(i * right.Count(x => x == i));
            }

            return similarityScores.Sum();
        }
    }
}
