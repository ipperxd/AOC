using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCTest;
public class AOC2023UnitTest
{
    [Fact]
    public void Day1Part1()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
        {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet"
        };

        // Act
        AOC_2023.Day1Solution day1Solution = new AOC_2023.Day1Solution();
        result = day1Solution.SolutionPart1(TestData);

        // Assert
         Assert.Equal(142, result);
    }

    [Fact]
    public void Day1Part2()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
        {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet"
        };
        AOC_2023.Day1Solution day1Solution1 = new AOC_2023.Day1Solution();

        // Act
        AOC_2023.Day1Solution day1Solution = new AOC_2023.Day1Solution();
        result = day1Solution.SolutionPart2(TestData);

        // Assert
        Assert.Equal(-1, result);
    }
}
