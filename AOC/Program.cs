// See https://aka.ms/new-console-template for more information
using AOC;
using AOC_2024;
using System.IO;

Day1Solution day = new Day1Solution();
Day2Solution day2 = new Day2Solution();

//Console.WriteLine("2024 Day 1 - part 1 Reuslt: " + day.SolutionPart1().ToString()); // Result = 2580760
//Console.WriteLine("2024 Day 1 - part 2 Reuslt: " + day.SolutionPart2().ToString()); // Result = 25358365
Console.WriteLine("2024 Day 1 - part 1 Reuslt: " + day2.SolutionPart1(SharedUtilities.LoadData("2024Day2.txt")).ToString()); // Result = 411
Console.WriteLine("2024 Day 1 - part 2 Reuslt: " + day2.SolutionPart2(SharedUtilities.LoadData("2024Day2.txt")).ToString()); // Result = 465