using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025;
public class Day1Solution : IDaySolution
{
    public int SolutionPart1(string[] data)
    {
        string[] lines = data;
        int result = 0;
        int counter = 50;

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            char turnDirection = line[0];
            int distance = int.Parse(line.Substring(1));
            // Each 90 degrees turn changes the direction index

            if (turnDirection == 'L')
            {
                for (int j = 0; j < distance; j++)
                {
                    counter--;
                    if (counter == -1)
                        counter = 99;
                }
            }
            else if (turnDirection == 'R')
            {
                for (int j = 0; j < distance; j++)
                {
                    counter++;
                    if (counter == 100)
                        counter = 0;
                }
            }
            if (counter == 0)
                result++;
        }


        return result;
    }

    public int SolutionPart2(string[] data)
    {
        string[] lines = data;
        int result = 0;
        int counter = 50;

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            char turnDirection = line[0];
            int distance = int.Parse(line.Substring(1));
            // Each 90 degrees turn changes the direction index

            if (turnDirection == 'L')
            {
                for (int j = 0; j < distance; j++)
                {
                    counter--;
                    if (counter == -1)
                    {
                        counter = 99;
                        result++;
                    }
                }
            }
            else if (turnDirection == 'R')
            {
                for (int j = 0; j < distance; j++)
                {
                    counter++;
                    if (counter == 100)
                    {
                        counter = 0;
                        result++;
                    }
                }
            }
        }


        return result;
    }
}
