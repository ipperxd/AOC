using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC_2025;
public class Day3Solution
{
    public int SolutionPart1(string[] data)
    {
        int result = 0;

        for (int i = 0; i < data.Length; i++)
        {
            var line = data[i];
            List<int> nums = new List<int>();

            int highestNumber = -1;
            int highestNumberIndex = -1;
            int secondHighestNumber = -1;

            for (int j = 0; j < line.Length; j++)
            {
               nums.Add(int.Parse(line[j].ToString()));
            }

            for (int k = 0; k < nums.Count - 1; k++)
            {
                if(nums[k] > highestNumber)
                {
                    highestNumber = nums[k];
                    highestNumberIndex = k;
                }
            }

            for (int m = highestNumberIndex + 1; m < nums.Count; m++)
            {
                if (nums[m] > secondHighestNumber)
                {
                    secondHighestNumber = nums[m];
                }
            }
            var stringHighest = highestNumber.ToString() + secondHighestNumber.ToString();
            result += int.Parse(stringHighest);
        }

        return result;
    }

    public long SolutionPart2(string[] data)
    {
        long result = 0;

        for (int i = 0; i < data.Length; i++)
        {
            var line = data[i];
            List<int> nums = new List<int>();
            List<int> resultList = new List<int>();

            for (int j = 0; j < line.Length; j++)
            {
                nums.Add(int.Parse(line[j].ToString()));
            }

            for (int k = nums.Count - 1; k >= 0; k--)
            {
               if(resultList.Count <= 11)
                {
                    resultList.Add(nums[k]);
                    
                }
                else
                {
                    if(nums[k] >= resultList.Last())
                    {
                        int lowestIndex = FindLowestNumberHighestIndex(resultList);
                        resultList.RemoveAt(lowestIndex);
                        resultList.Add(nums[k]);
                    }
                }
            }

            resultList.Reverse();
            var strResult = string.Join("", resultList);

            result += long.Parse(strResult);
        }

        return result;

    }

    public long ChattyAnswer(string[] data)
    {
        int targetLength = 12;

        long result = 0;

        for (int i = 0; i < data.Length; i++)
        {
            string line = data[i];
            Stack<int> stack = new Stack<int>();

            int digitsToRemove = line.Length - targetLength;

            foreach (char c in line)
            {
                int digit = c - '0';

                while (
                    stack.Count > 0 &&
                    digitsToRemove > 0 &&
                    stack.Peek() < digit
                )
                {
                    stack.Pop();
                    digitsToRemove--;
                }

                stack.Push(digit);
            }

            // Stack may be longer than 12 if we never used all removals
            while (stack.Count > targetLength)
            {
                stack.Pop();
            }

            var arr = stack.Reverse().ToArray();
            string strResult = string.Concat(arr);

            result += long.Parse(strResult);
        }

        return result;
    }

    public int FindLowestNumberHighestIndex(List<int> numbers)
    {
        int lowestNumber = int.MaxValue;
        int lowestNumberHighestIndex = -1;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] <= lowestNumber)
            {
                lowestNumber = numbers[i];
                lowestNumberHighestIndex = i;
            }
        }
        return lowestNumberHighestIndex;
    }
}
