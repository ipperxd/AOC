using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2024;
public class FacadeYear2024
{
    Day1Solution day1Solution = new Day1Solution();
    Day2Solution day2Solution = new Day2Solution();
    public int Day1Part1(string[] data)
    {
        return day1Solution.SolutionPart1(data);
    }
    public int Day1Part2(string[] data)
    {
        return day1Solution.SolutionPart2(data);
    }
    public int Day2Part1(string[] data)
    {
        return day2Solution.SolutionPart1(data);
    }
    public int Day2Part2(string[] data)
    {
        return day2Solution.SolutionPart2(data);
    }
}
