using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2024;

public class Day4_2024 : Iday
{
    string[] data;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2024\\Day4.txt");
    }

    public string Solution1()
    {
        SetData();

        int result = 0;
        char[,] grid = new char[data.Length, data[0].Length];

        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].Length; j++)
            {
                

                if(data[i][j] == 'X')
                {
                    
                    // - j
                    try {
                        if (data[i][j - 1] == 'M' && data[i][j - 2] == 'A' && data[i][j - 3] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch {  }

                    // + j
                    try
                    {
                        if (data[i][j + 1] == 'M' && data[i][j + 2] == 'A' && data[i][j + 3] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }

                    // + I
                    try
                    {
                        if (data[i + 1][j] == 'M' && data[i + 2][j] == 'A' && data[i + 3][j] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }

                    // - I
                    try
                    {
                        if (data[i - 1][j] == 'M' && data[i - 2][j] == 'A' && data[i - 3][j] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }

                    // ++
                    try
                    {
                        if (data[i + 1][j + 1] == 'M' && data[i + 2][j + 2] == 'A' && data[i + 3][j + 3] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }
                    // --
                    try
                    {
                        if (data[i - 1][j - 1] == 'M' && data[i - 2][j - 2] == 'A' && data[i - 3][j - 3] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }
                    
                    //+-
                    try {
                        if (data[i + 1][j - 1] == 'M' && data[i + 2][j - 2] == 'A' && data[i + 3][j - 3] == 'S')
                            result++;
                    }
                    catch { }
                    
                    //-+
                    try {
                        if (data[i - 1][j + 1] == 'M' && data[i - 2][j + 2] == 'A' && data[i - 3][j + 3] == 'S')
                        {
                            grid[i, j] = data[i][j];
                            result++;
                        }
                    }
                    catch { }
                    

                }
            }
            
        }
        return result.ToString();
    }


    public string Solution2()
    {
        SetData();

        int result = 0;

        char[,] grid = new char[data.Length, data[0].Length];

        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].Length; j++)
            {


                if (data[i][j] == 'A')
                {

                    // -- = M, ++ = S & +- = M, -+ = S

                    /*
                       M S
                        A
                       M S
                     */

                    try
                    {
                        if (data[i - 1][j - 1] == 'M' && data[i + 1][j + 1] == 'S' && data[i + 1][j - 1] == 'M' && data[i - 1][j + 1] == 'S')
                        {
                            result++;
                        }
                    }
                    catch { }

                    // -- = M, ++ = S & -+ = M, +- = S
                    /*
                       M M
                        A
                       S S
                     */
                    try
                    {
                        if (data[i - 1][j - 1] == 'M' && data[i + 1][j + 1] == 'S' && data[i - 1][j + 1] == 'M' && data[i + 1][j - 1] == 'S')
                        {
                            result++;
                        }
                    }
                    catch { }

                    // +- = M, -+ = S & ++ = M, -- = S
                    /*
                      S S
                       A
                      M M
                    */
                    try
                    {
                        if (data[i + 1][j - 1] == 'M' && data[i - 1][j + 1] == 'S' && data[i + 1][j + 1] == 'M' && data[i - 1][j - 1] == 'S')
                        {
                            result++;
                        }
                    }
                    catch { }

                    // ++ = M, -+ = S & -+ = M, -- = S
                    /*
                      S M
                       A
                      S M
                    */
                    try
                    {
                        if (data[i + 1][j + 1] == 'M' && data[i - 1][j - 1] == 'S' && data[i - 1][j + 1] == 'M' && data[i + 1][j - 1] == 'S')
                        {
                            result++;
                        }
                    }
                    catch { }

                }
            }

        }
        return result.ToString();
    }
}
