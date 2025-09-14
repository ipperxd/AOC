using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2024;
public class Day3Solutions: IDaySolution
{
    int result = 0;
    public int SolutionPart1(string[] data)
    {
        string[] lines = data;
        string line = lines[0];

        bool isWriting = false;
        string currentWord = "";

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == 'm')
            {
                isWriting = true;
                currentWord += line[i];

            }
        }
        return result;
    }



    public int SolutionPart2(string[] data)
    {

        string[] lines = data;
        result = 0;

        return result;

    }
}
