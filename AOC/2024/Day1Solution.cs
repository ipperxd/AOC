
namespace AOC_2024;
public class Day1Solution
{
    string[] lines = AOC.SharedUtilities.LoadData("2024Day1.txt");
    int result;


    List<int> LeftList = new List<int>();
    List<int> RighttList = new List<int>();

    public void Start()
    {
        result = 0;
        foreach (var line in lines)
        {
            LeftList.Add(int.Parse(line.Substring(0, 5).Trim()));
            RighttList.Add(int.Parse(line.Substring(6).Trim()));
        }
    }

    public int SolutionPart1()
    {
        Start();

        LeftList.Sort();
        RighttList.Sort();


        for (int i = 0; i < LeftList.Count; i++)
        {
            var x = (int)MathF.Abs(LeftList[i] - RighttList[i]);
            result += (int)x;
        }

        return result;
    }

    public int SolutionPart2()
    {
        Dictionary<int, int> leftRightPairs = new Dictionary<int, int>();
        
        Start();

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

        return result;
    }
}
