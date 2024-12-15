using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Repository._2015;

public class Day1_2015 : Iday
{
    string[]? data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2015\\Day1.txt");
    }

    public string Solution1()
    {
        SetData();

        int result = 0;

        char[] symbols = data[0].ToArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == '(')
                result++;
            else if (symbols[i] == ')')
                result--;
        }

        return result.ToString();
    }

    public string Solution2()
    {
        SetData();

        int position = 0;
        int result = 0;

        char[] symbols = data[0].ToArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == '(')
                position++;
            else if (symbols[i] == ')')
                position--;

            if (position == -1)
            {
                result = i + 1;
                break;
            }
        }

        return result.ToString();
    }
}
