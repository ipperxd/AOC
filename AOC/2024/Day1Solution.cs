
using AOC.Interface;

namespace AOC_2024;
public class Day1Solution : IDaySolution
{
    int result;


    List<int> LeftList = new List<int>();
    List<int> RighttList = new List<int>();

    public void Start(string[] data)
    {
        LeftList.Clear();
        RighttList.Clear();
        result = 0;
        foreach (var line in data)
        {
            var x = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            LeftList.Add(int.Parse(x[0]));
            RighttList.Add(int.Parse(x[1]));
        }
    }

    public int SolutionPart1(string[] data)
    {
        Start(data);

        LeftList.Sort();
        RighttList.Sort();


        for (int i = 0; i < LeftList.Count; i++)
        {
            var x = (int)MathF.Abs(LeftList[i] - RighttList[i]);
            result += (int)x;
        }

        return result;
    }

    public int SolutionPart2(string[] data)
    {
        Start(data);

        for (int i = 0; i < LeftList.Count; i++)
        {
            int addingUp = 0;

            for (int j = 0; j < RighttList.Count; j++)
            {
                if (RighttList[i] == LeftList[j])
                {
                    addingUp++;
                }
            }

            result += addingUp * RighttList[i]; 
        }
        

        return result;
    }
}
