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
            "two1nine",
            "eightwothree",
            "abcone2threexyz",
            "xtwone3four",
            "4nineeightseven2",
            "zoneight234",
            "7pqrstsixteen"
        };

        // Act
        AOC_2023.Day1Solution day1Solution = new AOC_2023.Day1Solution();
        result = day1Solution.SolutionPart2(TestData);

        // Assert
        Assert.Equal(281, result);
    }

    [Fact]
    public void Day2Part1()
    {
        // Arrange
        var result = 0;

        var TestData = new string[]
        {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
        };

        // Act
        AOC_2023.Day2Solution day2Solution = new AOC_2023.Day2Solution();
        result = day2Solution.SolutionPart1(TestData);

        // Assert
        Assert.Equal(0, result);

    }

}
