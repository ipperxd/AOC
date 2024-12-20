using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2017;
public class Day1_2017 : Iday
{
    string[] data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2017\\Day1.txt");
    }

    public string Solution1()
    {
        SetData();

        int result = 0;

        for (int i = 0; i < data[0].Length; i++)
        {
            try
            {
                if (data[0][i] == data[0][i + 1])
                {
                    Console.WriteLine(Int32.Parse(data[0][i].ToString()) + " " + Int32.Parse(data[0][i + 1].ToString()));
                    result += Int32.Parse(data[0][i].ToString());
                    Console.WriteLine("New Result " + result.ToString() + " ");
                }
            }
            catch (Exception e) {
                if(Int32.Parse(data[0][0].ToString()) == Int32.Parse(data[0][data[0].Length - 1].ToString())){
                    int cal = Int32.Parse(data[0][0].ToString());
                    result += cal;
                    Console.WriteLine("New Result " + result.ToString() + " " + cal.ToString());
                }
            }
            
        }

        return result.ToString();
    }

    public string Solution2()
    {
        SetData();

        int result = 0;
        var string1 = data[0].Substring(0,data[0].Length /2);
        var string2 = data[0].Substring(data[0].Length / 2, data[0].Length / 2);

        for (int i = 0; i < string1.Length; i++)
        {
            if (string1[i] == string2[i])
            {
                var k = Int32.Parse(string1[i].ToString()) + Int32.Parse(string2[i].ToString());
                result += k;
            }

        }

        return result.ToString();
    }
}
