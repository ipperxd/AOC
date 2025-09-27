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
        int result = 0;

        List<string> words = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < data.Length; i++)
        {
            string s = "";
            List<int> nums = new List<int>();
            for (int j = 0; j < data[i].Length; j++)
            {

                var c = data[i][j];
                var check = s;

                if (char.IsDigit(data[i][j]))
                {
                   
                    nums.Add(int.Parse(data[i][j].ToString()));
                }
                else
                {
                    s += data[i][j];
                    if (s)
                    {
                        nums.Add(ToNumber(s));
                        s = "";
                    }
                }
            }

            var x = nums.First().ToString() + nums.Last().ToString();
            result += int.Parse(x);
        }


        return result;
    }



    public static int ToNumber(string s) => s switch
    {
        "one" => 1,
        "two" => 2,
        "three" => 3,
        "four" => 4,
        "five" => 5,
        "six" => 6,
        "seven" => 7,
        "eight" => 8,
        "nine" => 9
    };

}
