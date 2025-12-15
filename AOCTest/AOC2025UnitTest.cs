using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCTest;
public class AOC2025UnitTest
{
    [Fact]
    public void Day1Part1()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
       {
         "L68",
         "L30",
         "R48",
         "L5",
         "R60",
         "L55",
         "L1",
         "L99",
         "R14",
         "L82"
       };

        AOC_2025.Day1Solution day1Solution = new AOC_2025.Day1Solution();
        // Act
        result = day1Solution.SolutionPart1(TestData);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Day1Part2() {
        var result = 0;
        var TestData = new string[]
       {
         "L68",
         "L30",
         "R48",
         "L5",
         "R60",
         "L55",
         "L1",
         "L99",
         "R14",
         "L82"
       };

        AOC_2025.Day1Solution day1Solution = new AOC_2025.Day1Solution();
        // Act
        result = day1Solution.SolutionPart2(TestData);
        // Assert
        Assert.Equal(6, result);
    }
}
