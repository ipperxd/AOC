using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2023;
public class Day1Solution : AOC.Interface.IDaySolution
{
    public int SolutionPart1(string[] data)
    {
        int result = 0;

        for (int i = 0; i < data.Length; i++)
        {
            List<int> nums = new List<int>();
            for (int j = 0; j < data[i].Length; j++)
            {
                if (char.IsDigit(data[i][j]))
                {
                    nums.Add(int.Parse(data[i][j].ToString()));
                }
            }

            var x = nums.First().ToString() + nums.Last().ToString();
            result += int.Parse(x);
        }


        return result;
    }

    public int SolutionPart2(string[] data)
    {
        throw new NotImplementedException();
    }
}
