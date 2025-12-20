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

    [Fact]
    public void Day2Part1()
    {
        long result = 0;
        var TestData = new string[]
       {
         "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124"
       };
        AOC_2025.Day2Solution day2Solution = new AOC_2025.Day2Solution();
        
        // Act
        result = day2Solution.SolutionPart1(TestData);
       
        // Assert
        Assert.Equal(1227775554, result);
    }

    [Fact]
    public void Day2Part2()
    {
        long result = 0;
        var TestData = new string[]
       {
         "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124"
       };
        AOC_2025.Day2Solution day2Solution = new AOC_2025.Day2Solution();

        // Act
        result = day2Solution.SolutionPart2(TestData);

        // Assert
        Assert.Equal(4174379265, result);
    }
}
