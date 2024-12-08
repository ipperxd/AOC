using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2024;

public class Day1_2024 : Iday
{
    string[]? data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2024\\Day1.txt");
    }
    public string Solution1()
    {
        SetData();

        int result = 0;

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            string[] splittedArray = data[i].Split(new char[] { ' ' }, 5);
            firstList.Add(int.Parse(splittedArray[0]));
            secondList.Add(int.Parse(splittedArray[1]));
        }

        firstList.Sort();
        secondList.Sort();

        for (int i = 0; i < firstList.Count; i++)
        {
            int diff = Math.Abs(firstList[i] - secondList[i]); 
            Console.WriteLine(firstList[i] + " " + secondList[i] + " " + diff);
            result += diff;
        } 


        return result.ToString();
    }

    public string Solution2()
    {
        SetData();

        int result = 0;

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            string[] splittedArray = data[i].Split(new char[] { ' ' }, 2);
            firstList.Add(int.Parse(splittedArray[0]));
            secondList.Add(int.Parse(splittedArray[1]));
        }

        firstList.Sort();
        secondList.Sort();

        for (int i = 0;i < firstList.Count; i++)
        {
            var count = 0;
            var value = firstList[i];
            for (int j = 0; j < secondList.Count; j++)
            {
                if (firstList[i] == secondList[j])
                {
                    count++;
                }
            }

            result += count * value;

        }
        return result.ToString();
    }
}
