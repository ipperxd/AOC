using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025;

public class FacadeYear2025
{
    Day1Solution day1Solution = new Day1Solution();
    public int Day1Part1(string[] data)
    {
        return day1Solution.SolutionPart1(data);
    }
    public int Day1Part2(string[] data)
    {
        return day1Solution.SolutionPart2(data);
    }

    public Day2Solution Day2Solution = new Day2Solution();

    public long Day2Part1(string[] data)
    {
        return Day2Solution.SolutionPart1(data);
    }
    public long Day2Part2(string[] data)
    {
        return Day2Solution.SolutionPart2(data);
    }

    public Day3Solution Day3Solution = new Day3Solution();
    public int Day3Part1(string[] data)
    {
        return Day3Solution.SolutionPart1(data);
    }

    public long Day3Part2(string[] data)
    {
        return Day3Solution.ChattyAnswer(data);
    }
}
