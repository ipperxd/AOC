
namespace AOC_2024
{
    public class Day1Solution
    {
        string[] lines = AOC.SharedUtilities.LoadData("2024Day1.txt");

        int result = 0;

        List<int> LeftList = new List<int>();
        List<int> RighttList = new List<int>();

        public int SolutionPart1()
        {
            foreach (var line in lines)
            {
                LeftList.Add(int.Parse(line.Substring(0, 5).Trim()));
                RighttList.Add(int.Parse(line.Substring(6).Trim()));
            }

            LeftList.Sort();
            RighttList.Sort();


            for (int i = 0; i < LeftList.Count; i++)
            {
                var x = (int)MathF.Abs(LeftList[i] - RighttList[i]);
                result += (int)x;
            }

            Console.WriteLine($"Day 1 result is: {result}");
            return result;
        }

        public int SolutionPart2()
        {
            Dictionary<int, int> leftRightPairs = new Dictionary<int, int>();
            for (int i = 0; i < RighttList.Count; i++)
            {
                if (LeftList.Contains(RighttList[i]))
                {
                    if (!leftRightPairs.ContainsKey(RighttList[i]))
                    {
                        leftRightPairs[RighttList[i]] = 1;
                    }
                    else
                    {
                        leftRightPairs[RighttList[i]]++;
                    }
                }
            }
            foreach (var pair in leftRightPairs)
            {
                result += pair.Key * pair.Value;
            }

            Console.WriteLine($"Day 2 result is: {result}");
            return result;
        }
    }
}
