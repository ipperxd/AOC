// See https://aka.ms/new-console-template for more information
using AOC;
using AOC_2023;
using AOC_2024;
using AOC_2025;
using System.IO;

FacadeYear2023 facadeYear2023 = new FacadeYear2023();

//Console.WriteLine( facadeYear2023.Day1Part1(SharedUtilities.LoadData("2023/2023Day1.txt"))); // Result = 54081
//Console.WriteLine(facadeYear2023.Day1Part2(SharedUtilities.LoadData("2023/2023Day1.txt"))); // Result = 54649

FacadeYear2024 facadeYear2024 = new FacadeYear2024();

//Console.WriteLine(facadeYear2024.Day1Part1(SharedUtilities.LoadData("2024/2024Day1.txt"))); // Result = 2580760
//Console.WriteLine(facadeYear2024.Day1Part2(SharedUtilities.LoadData("2024/2024Day1.txt"))); // Result = 25358365
//Console.WriteLine(facadeYear2024.Day2Part1(SharedUtilities.LoadData("2024/2024Day2.txt"))); // Result = 411
//Console.WriteLine(facadeYear2024.Day2Part2(SharedUtilities.LoadData("2024/2024Day2.txt"))); // Result = 465

FacadeYear2025 facadeYear2025 = new FacadeYear2025();
Console.WriteLine(facadeYear2025.Day1Part1(SharedUtilities.LoadData("2025/2025Day1.txt"))); // Result = 1154
Console.WriteLine(facadeYear2025.Day1Part2(SharedUtilities.LoadData("2025/2025Day1.txt"))); // Result = 6819

Console.WriteLine(facadeYear2025.Day2Part1(SharedUtilities.LoadData("2025/2025Day2.txt"))); // Result = 17077011375
Console.WriteLine(facadeYear2025.Day2Part2(SharedUtilities.LoadData("2025/2025Day2.txt"))); // Result = 36037497037

Console.WriteLine(facadeYear2025.Day3Part1(SharedUtilities.LoadData("2025/2025Day3.txt"))); // Result = 17179

// I had a long talk with ChatGPT to get this working and i finally understood what was wrong with my initial approach.
// I know it is cheating, but better to try, fail and learn than to stay stuck forever...
Console.WriteLine(facadeYear2025.Day3Part2(SharedUtilities.LoadData("2025/2025Day3.txt"))); // Result = My - 169959329789057 (To low...) - Real and chat - 170025781683941  Difference : 66.451.894.884