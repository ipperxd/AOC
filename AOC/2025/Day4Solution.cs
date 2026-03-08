using AOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025;
public class Day4Solution : IDaySolution
{
    public int SolutionPart1(string[] data)
    {

        int result = 0;
        int[,] grid = new int[data.Length, data[0].Length];

        for (int x = 0; x < data.Length; x++)
        {
            for (int y = 0; y < data[x].Length; y++)
            {
                grid[x, y] = data[x][y] == '@' ? 1 : 0;
            }
        }


        for (int x = 0; x < data.Length; x++)
        {
            for (int y = 0; y < data[x].Length; y++)
            {
                if (grid[x, y] == 1)
                {
                    int adjecentCount = 0;
                    // Up
                    if(isInsideGrid(x - 1, y, data.Length, data[x].Length))
                        if(grid[x - 1, y] == 1)
                            adjecentCount++;

                    // Down
                    if (isInsideGrid(x + 1, y, data.Length, data[x].Length))
                        if (grid[x + 1, y] == 1)
                            adjecentCount++;

                    // Right
                    if(isInsideGrid(x, y + 1, data.Length, data[x].Length))
                        if (grid[x, y + 1] == 1)
                            adjecentCount++;
                    
                    // Left
                    if(isInsideGrid(x, y - 1, data.Length, data[x].Length))
                        if (grid[x, y - 1] == 1)
                            adjecentCount++;

                    // Diagonal Right Up
                    if(isInsideGrid(x - 1, y + 1, data.Length, data[x].Length))
                        if (grid[x - 1, y + 1] == 1)
                            adjecentCount++;

                    // Diagonal Left Up
                    if(isInsideGrid(x - 1, y - 1, data.Length, data[x].Length))
                        if (grid[x - 1, y - 1] == 1)
                            adjecentCount++;

                    // Diagonal Right Down
                    if(isInsideGrid(x + 1, y + 1, data.Length, data[x].Length))
                        if (grid[x +1, y + 1] == 1)
                            adjecentCount++;

                    // Diagonal Left Down
                    if(isInsideGrid(x + 1, y - 1, data.Length, data[x].Length))
                        if (grid[x + 1, y - 1] == 1 )
                            adjecentCount++;

                    if(adjecentCount < 4)
                        result++;
                   
                }
            }
        }
        return result;
    }

    public int SolutionPart2(string[] data)
    {
        int result = 0;
        int removed = -1;
        int[,] grid = new int[data.Length, data[0].Length];
        List<(int, int)> toRemove = new List<(int, int)>();

        for (int x = 0; x < data.Length; x++)
        {
            for (int y = 0; y < data[x].Length; y++)
            {
                grid[x, y] = data[x][y] == '@' ? 1 : 0;
            }
        }

        while(removed != 0)
        {
            toRemove.Clear();
            removed = 0;
            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[x].Length; y++)
                {
                    if (grid[x, y] == 1)
                    {
                        int adjecentCount = 0;
                        // Up
                        if (isInsideGrid(x - 1, y, data.Length, data[x].Length))
                            if (grid[x - 1, y] == 1)
                                adjecentCount++;

                        // Down
                        if (isInsideGrid(x + 1, y, data.Length, data[x].Length))
                            if (grid[x + 1, y] == 1)
                                adjecentCount++;

                        // Right
                        if (isInsideGrid(x, y + 1, data.Length, data[x].Length))
                            if (grid[x, y + 1] == 1)
                                adjecentCount++;

                        // Left
                        if (isInsideGrid(x, y - 1, data.Length, data[x].Length))
                            if (grid[x, y - 1] == 1)
                                adjecentCount++;

                        // Diagonal Right Up
                        if (isInsideGrid(x - 1, y + 1, data.Length, data[x].Length))
                            if (grid[x - 1, y + 1] == 1)
                                adjecentCount++;

                        // Diagonal Left Up
                        if (isInsideGrid(x - 1, y - 1, data.Length, data[x].Length))
                            if (grid[x - 1, y - 1] == 1)
                                adjecentCount++;

                        // Diagonal Right Down
                        if (isInsideGrid(x + 1, y + 1, data.Length, data[x].Length))
                            if (grid[x + 1, y + 1] == 1)
                                adjecentCount++;

                        // Diagonal Left Down
                        if (isInsideGrid(x + 1, y - 1, data.Length, data[x].Length))
                            if (grid[x + 1, y - 1] == 1)
                                adjecentCount++;


                        if (adjecentCount < 4)
                        {
                            result++;
                            toRemove.Add((x, y));
                        }

                    }
                }
            }
            foreach(var item in toRemove)
            {
                grid[item.Item1, item.Item2] = 0;
                removed++;
            }
        }

        return result;
    }

    public bool isInsideGrid(int x, int y, int maxX, int maxY)
    {
        return x >= 0 && x < maxX && y >= 0 && y < maxY;
    }
}
