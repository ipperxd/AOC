using AOC_2024;

namespace AOCTest
{
    public class AOCUnitTest
    {
        [Fact]
        public void Day1Part1()
        {
            // Arrange
            var result = 0;
            Day1Solution day1Solution = new Day1Solution();

            // Act
            result = day1Solution.SolutionPart1();

            // Assert
            Assert.Equal(2580760, result);
        }

        [Fact]
        public void Day1Part2()
        {
            // Arrange
            var result = 0;
            Day1Solution day1Solution1 = new Day1Solution();


            // Act
            result = day1Solution1.SolutionPart2();

            Console.WriteLine(result);

            // Assert

            Assert.Equal(27939125, result);
        }
    }
}
