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


    [Fact]
    public void Day3Part1()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
       {
         "987654321111111",
         "811111111111119",
         "234234234234278",
         "818181911112111"
       };
        AOC_2025.Day3Solution day3Solution = new AOC_2025.Day3Solution();
        // Act
        result = day3Solution.SolutionPart1(TestData);
        // Assert
        Assert.Equal(357, result);
    }


    [Fact]
    public void Day3Part2()
    {
        // Arrange
        long result = 0;
        var TestData = new string[]
       {
         "987654321111111",
         "811111111111119",
         "234234234234278",
         "818181911112111"
       };
        AOC_2025.Day3Solution day3Solution = new AOC_2025.Day3Solution();
        // Act
        result = day3Solution.SolutionPart2(TestData);
        // Assert
        Assert.Equal(3121910778619, result);
    }

    [Fact]
    public void Day3Part2Version2()
    {
        // Arrange
        long result = 0;
        var TestData = new string[]
       {
         "7657222591427217122445272425253565561122226426262235211484443362522725526264152632322121122211226432",
         "3373333633442752337522633445663374225443334322548433257443232874664837733346552233522456333621353345",
         "1332222423213233321341322323233232323313322333313132332432322231343233323222222322322223132223242221",
         "2542511113222221222322623512315322253412425222332222424222523225123222231222224522222222222123312322"
       };

        AOC_2025.Day3Solution day3Solution = new AOC_2025.Day3Solution();

        // Ac

        result = day3Solution.ChattyAnswer(TestData);
        // Assert
        Assert.Equal(2976431897330, result);
    }

    [Fact]
    public void Day4Part1()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
           {
            "..@@.@@@@.",
            "@@@.@.@.@@",
            "@@@@@.@.@@",
            "@.@@@@..@.",
            "@@.@@@@.@@",
            ".@@@@@@@.@",
            ".@.@.@.@@@",
            "@.@@@.@@@@",
            ".@@@@@@@@.",
            "@.@.@@@.@."
           };

        AOC_2025.Day4Solution day4Solution = new AOC_2025.Day4Solution();
        // Act
        result = day4Solution.SolutionPart1(TestData);
        // Assert
        Assert.Equal(13, result);
    }

    [Fact]
    public void Day4Part2()
    {
        // Arrange
        var result = 0;
        var TestData = new string[]
           {
            "..@@.@@@@.",
            "@@@.@.@.@@",
            "@@@@@.@.@@",
            "@.@@@@..@.",
            "@@.@@@@.@@",
            ".@@@@@@@.@",
            ".@.@.@.@@@",
            "@.@@@.@@@@",
            ".@@@@@@@@.",
            "@.@.@@@.@."
           };

        AOC_2025.Day4Solution day4Solution = new AOC_2025.Day4Solution();
        // Act
        result = day4Solution.SolutionPart2(TestData);
        // Assert
        Assert.Equal(43, result);
    }

    [Fact]
    public void Day5Part1()
    {
        // Arrange
        long result = 0;
        var TestData = new string[]
           {
            "3-5",
            "10-14",
            "16-20",
            "12-18",
            "",
            "1",
            "5",
            "8",
            "11",
            "17",
            "32"
           };

        AOC_2025.Day5Solution day5Solution = new AOC_2025.Day5Solution();
        // Act
        result = day5Solution.SolutionPart1(TestData);
        // Assert
        Assert.Equal(3, result);
    }


}
