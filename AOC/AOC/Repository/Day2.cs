using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository;

public class Day2 : Iday
{
    string[]? data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("Day2.txt");
    }
    public string Solution1()
    {
        SetData();
        var result = 0;
        List<string> listOfInputs = new List<string>();

        listOfInputs = data.ToList();

        foreach (string Inputs in listOfInputs)
            result += CalculateScorePartOne(Inputs[0], Inputs[2]);

        return result.ToString();
    }

    public string Solution2()
    {
        SetData();
        var result = 0;
        List<string> listOfInputs = new List<string>();

        listOfInputs = data.ToList();

        foreach (string Inputs in listOfInputs)
            result += CalculateScorePartTwo(Inputs[0], Inputs[2]);

        return result.ToString();
    }

    int CalculateScorePartTwo
        (char Enemy, char FixedResult)
    {
        var result = 0;

        switch (Enemy)
        {
            case 'A':
                if (FixedResult == 'X')
                    result += 3 + 0;
                else if (FixedResult == 'Y')
                    result += 1 + 3;
                else if (FixedResult == 'Z')
                    result += 2 + 6;
                break;
            case 'B':
                if (FixedResult == 'X')
                    result += 1 + 0;
                else if (FixedResult == 'Y')
                    result += 2 + 3;
                else if (FixedResult == 'Z')
                    result += 3 + 6;
                break;
            case 'C':
                if (FixedResult == 'X')
                    result += 2 + 0;
                else if (FixedResult == 'Y')
                    result += 3 + 3;
                else if (FixedResult == 'Z')
                    result += 1 + 6;
                break;
        }

        return result;
    }

    int CalculateScorePartOne
        (char Enemy, char my)
    {
        int result = 0;

        switch (Enemy)
        {
            case 'A':
                if (my == 'X')
                    result += 1 + 3;
                else if (my == 'Y')
                    result += 2 + 6;
                else if (my == 'Z')
                    result += 3;
                break;
            case 'B':
                if (my == 'X')
                    result += 1 + 0;
                else if (my == 'Y')
                    result += 2 + 3;
                else if (my == 'Z')
                    result += 3 + 6;
                break;
            case 'C':
                if (my == 'X')
                    result += 1 + 6;
                else if (my == 'Y')
                    result += 2 + 0;
                else if (my == 'Z')
                    result += 3 + 3;
                break;
        }
        return result;
    }
}
