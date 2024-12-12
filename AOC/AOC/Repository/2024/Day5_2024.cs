using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2024;

public class Day5_2024 : Iday
{
    string[] data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2024\\Day5.txt");
    }

    public string Solution1()
    {
        SetData();

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();

        List<int> rules = new List<int>();


        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);

            if (data[i].Contains('|'))
                list1.Add(data[i]);
            
            else if (data[i].Contains(','))
                list2.Add(data[i]);
        }


        for (int i = 0; i < list1.Count; i++)
        {
            var x = int.Parse(list1[i][0].ToString());
            var Y = int.Parse(list1[i][2].ToString());

            if (rules.Contains(x))
            {
            }


        }

        Console.WriteLine(list1.Count.ToString());
        Console.WriteLine(list2.Count.ToString());

        return data[0];
        throw new NotImplementedException();
    }

    public string Solution2()
    {
        throw new NotImplementedException();
    }
}

