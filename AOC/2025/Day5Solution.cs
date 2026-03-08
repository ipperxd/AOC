using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025;
public class Day5Solution
{
    public long SolutionPart1(string[] data)
    {
        long result = 0;
        List<long> firstList = new List<long>();
        List<long> secondList = new List<long>();

        for (int i = 0; i < data.Length; i++)
        {
            var line = data[i];

            if (line.Contains('-'))
            {
                long first = long.Parse(line.Split('-')[0]);
                long second = long.Parse(line.Split('-')[1]);

                for (long num = first; num <= second; num++)
                {
                   if(!firstList.Contains(num))
                        firstList.Add(num);
                }
                
            }
            else if (line == "")
            {
                continue;
            }
            else
            {
                long number = int.Parse(line);
                secondList.Add(number);
            }
        }

        secondList = secondList.Distinct().ToList();

        foreach (var num in secondList)
        {
            if (firstList.Contains(num))
            {
                result++;
            }
        }

        return result;
    }

    public int SolutionPart2(string[] data)
    {
        throw new NotImplementedException();
    }
}
