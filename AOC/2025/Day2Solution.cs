using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025;
public class Day2Solution 
{
    public long SolutionPart1(string[] data)
    {
        string[] lines = data;
        long result = 0;

        var x = lines[0].Split(',');

        for (int i = 0; i < x.Length; i++)
        {
            var y = x[i].Split("-");

            List<long> numbers = new List<long>();

            var num = long.Parse(y[1]) - long.Parse(y[0]);

            for (int k = 0; k < num; k++)
            {
                numbers.Add(long.Parse(y[0]) + k);
            }

            numbers.Add(long.Parse(y[1]));


            for (int j = 0; j < numbers.Count; j++)
            {

                var strNum = numbers[j].ToString();

                if (strNum.Length % 2 != 0)
                    continue;

                var z1 = int.Parse(strNum.Substring(strNum.Length/2));
                var z2 = int.Parse(strNum.Substring(0, strNum.Length / 2));

                if (z1 == z2)
                    result += numbers[j];

            }
        }

        return result;
    }

    public long SolutionPart2(string[] data)
    {
        string[] lines = data;
        List<long> validNumbers = new List<long>();
        long result = 0;

        var x = lines[0].Split(',');

        for (int i = 0; i < x.Length; i++)
        {
            var y = x[i].Split("-");

            List<string> numbers = new List<string>();

            var num = long.Parse(y[1]) - long.Parse(y[0]);

            for (int k = 0; k < num; k++)
            {
                var strNum = (long.Parse(y[0]) + k).ToString();
                numbers.Add(strNum);
            }

            numbers.Add(long.Parse(y[1]).ToString());


            for (int j = 0; j < numbers.Count; j++)
            {
                for (int splitSize = 1; splitSize <= numbers[j].Length / 2; splitSize++)
                {
                    if (numbers[j].Length % splitSize != 0)
                        continue;

                    var chunks = Split(numbers[j], splitSize).ToList();
                    bool allEqual = chunks.All(c => c == chunks[0]);
                    if (allEqual)
                    {
                        result += long.Parse(numbers[j]);
                        break;
                    }
                }
            }
        }

        return result;
    }

    static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
}


