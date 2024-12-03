using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Repository._2024;

public class Day2_2024 : Iday
{
    string[]? data;
    
    public void SetData()
    {
        data = Utility.Utility.LoadData("2024\\Day2.txt");
    }

    public string Solution1()
    {
        SetData();
        int result = 0;
        
        for (int i = 0; i < data.Length; i++)
        {
            int? countP = 0;
            int? countN = 0;
            List<int> list = new List<int>();
            string[] numbersToCheck = data[i].Split(new char[] { ' ' });

            foreach (var item in numbersToCheck)
            {
                list.Add(int.Parse(item));
            }

            for (int j = 1; j < list.Count; j++)
            {
                var f = list[j];
                var ft = list[j - 1];

                if (f > ft && f  <= ft +3 )
                {
                    countP++;
                }
                else if (f < ft && f >= ft - 3)
                {
                    countN++;
                }
            }

            if (countP == list.Count - 1 || countN == list.Count - 1)
                result++;
        }

        return result.ToString();
    }

    public string Solution2()
    {
        SetData();
        int result = 0;

        for (int i = 0; i < data.Length; i++)
        {
            
            List<int> list = new List<int>();
            
            string[] numbersToCheck = data[i].Split(new char[] { ' ' });

            foreach (var item in numbersToCheck)
            {
                list.Add(int.Parse(item));
            }

            bool valid = SatisfiesCondition(list);

            if (!valid)
            {
                bool canFix = false;

                for (int n = 0; n < list.Count; n++)
                {
                    // Create a copy of the sublist with one element removed
                    var modifiedList = new List<int>(list);
                    modifiedList.RemoveAt(n);

                    if (SatisfiesCondition(modifiedList))
                    {
                        var s = string.Join(";", modifiedList);
                        Console.WriteLine(s);
                        canFix = true;
                        result++;
                        break;
                    }
                }
            }

            else
                result++;
                 

        }

        return result.ToString();
    }

    public bool SatisfiesCondition(List<int> list)
    {
        int countP = 0;
        int countN = 0;

        for (int j = 1; j < list.Count; j++)
        {
            if ((list[j] > list[j - 1] && list[j] <= list[j - 1] + 3))
            {
                countP++;
            }
            else if ((list[j] < list[j - 1] && list[j] >= list[j - 1] - 3))
            {
                countN++;
            }

            if (countP == list.Count - 1 || countN == list.Count - 1)
                return true;
        }
        return false;
    }
}
