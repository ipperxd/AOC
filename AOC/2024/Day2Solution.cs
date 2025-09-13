using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC_2024;
public class Day2Solution
{
  //   string[] lines = AOC.SharedUtilities.LoadData("2024Day2.txt");

    int result = 0;

    public int SolutionPart1(string[] data)
    {

        string[] lines = data;
        result = 0;

        List<int> nums;

        foreach (var line in lines)
        {
            nums = new List<int>();
            string x = "";
            
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    x += line[i];
                }
                else
                {
                    int num = int.Parse(x);
                    nums.Add(num);
                    x = "";
                }
            }

            int temp = int.Parse(x);
            nums.Add(temp);
            x = "";


            bool checkIfIncrease = false;
            bool checkifDecrease = false;
            bool checkSize = false;


            for (int i = 0; i < nums.Count - 1; i++)
            {
                int temp1 = nums[i];
                int temp2 = nums[i + 1];
                int delta = Math.Abs(temp1 - temp2);


                if (delta == 0 || delta > 3)
                {
                    checkSize = true;
                }

                if (nums[i] < nums[i + 1] )
                {
                    checkIfIncrease = true;
                }

                 if (nums[i] > nums[i + 1])
                {
                    checkifDecrease = true;
                }              
            }

            if (!checkSize && checkIfIncrease && !checkifDecrease ||
                !checkSize && !checkIfIncrease && checkifDecrease)
                result++;

        }

        return result;
    }



    public int SolutionPart2(string[] data)
    {

        string[] lines = data;
        result = 0;

        List<int> nums;


        foreach (var line in lines)
        {
            nums = new List<int>();
            string x = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    x += line[i];
                }
                else
                {
                    int num = int.Parse(x);
                    nums.Add(num);
                    x = "";
                }
            }

            int temp = int.Parse(x);
            nums.Add(temp);
            x = "";

            List<List<int>> allCombos = new List<List<int>>();
            allCombos.Add(nums);

            for (int i = 0; i < nums.Count; i++)
            {
                List<int> tempList = new List<int>(nums);
                tempList.RemoveAt(i);
                allCombos.Add(tempList);

            }

            bool OneBoolToRuleThemAll = false;


            for (int j = 0; j < allCombos.Count; j++)
            {
                List<int> tempList = allCombos[j];
                bool checkIfIncrease = false;
                bool checkifDecrease = false;
                bool checkSize = false;

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    int temp1 = tempList[i];
                    int temp2 = tempList[i + 1];
                    int delta = Math.Abs(temp1 - temp2);


                    if (delta == 0 || delta > 3)
                    {
                        checkSize = true;
                    }

                    if (tempList[i] < tempList[i + 1])
                    {
                        checkIfIncrease = true;
                    }

                    if (tempList[i] > tempList[i + 1])
                    {
                        checkifDecrease = true;
                    }
                }

                if (!checkSize && checkIfIncrease && !checkifDecrease ||
                    !checkSize && !checkIfIncrease && checkifDecrease)
                    OneBoolToRuleThemAll = true;
            }

            if(OneBoolToRuleThemAll)
                result++;

        }

        return result;

    }
}
