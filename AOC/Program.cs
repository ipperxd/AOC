// See https://aka.ms/new-console-template for more information
using AOC;
using AOC_2023;
using AOC_2024;
using System.IO;

FacadeYear2023 facadeYear2023 = new FacadeYear2023();

Console.WriteLine( facadeYear2023.Day1Part1(SharedUtilities.LoadData("2023/2023Day1.txt"))); // Result = 75501

FacadeYear2024 facadeYear2024 = new FacadeYear2024();


Console.WriteLine(facadeYear2024.Day1Part1(SharedUtilities.LoadData("2024/2024Day1.txt"))); // Result = 2580760
Console.WriteLine(facadeYear2024.Day1Part2(SharedUtilities.LoadData("2024/2024Day1.txt"))); // Result = 25358365
Console.WriteLine(facadeYear2024.Day2Part1(SharedUtilities.LoadData("2024/2024Day2.txt"))); // Result = 411
Console.WriteLine(facadeYear2024.Day2Part2(SharedUtilities.LoadData("2024/2024Day2.txt"))); // Result = 465