using AOC_2024;

namespace AOCTest
{
    public class AOC2024UnitTest
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

            var TestData = new string[]
            {
                "3   4",
                "4   3",
                "2   5",
                "1   3",
                "3   9",
                "3   3",
            };

            Day1Solution day1Solution1 = new Day1Solution();


            // Act
            result = day1Solution1.SolutionPart2();

            Console.WriteLine(result);

            // Assert

            Assert.Equal(25358365, result);
        }


        [Fact]
        public void Day2Part1()
        {
            // Arrange
            var result = 0;

            var TestData = new string[]
            {
                "7 6 4 2 1",
                "1 2 7 8 9",
                "9 7 6 2 1",
                "1 3 2 4 5",
                "8 6 4 4 1",
                "1 3 6 7 9",
            };

            Day2Solution day2Solution = new Day2Solution();
            // Act
            result = day2Solution.SolutionPart1(TestData);
            // Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Day2Part2()
        {
            // Arrange
            var result = 0;

            var TestData = new string[]
            {
                "7 6 4 2 1",
                "1 2 7 8 9",
                "9 7 6 2 1",
                "1 3 2 4 5",
                "8 6 4 4 1",
                "1 3 6 7 9",
            };

            Day2Solution day2Solution = new Day2Solution();
            // Act
            result = day2Solution.SolutionPart2(TestData);
            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Day3Part1()
        {
            // Arrange
            var result = 0;

            var TestData = new string[]
            {
                "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))"
            };

            Day3Solutions day3Solution = new Day3Solutions();
            // Act
            result = day3Solution.SolutionPart1(TestData);
            // Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Day3Part2()
        {
            // Arrange
            var result = 0;

            var TestData = new string[]
           {
                "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))"
           };

            Day3Solutions day3Solution = new Day3Solutions();
            // Act
            result = day3Solution.SolutionPart2(TestData);
            // Assert
            Assert.Equal(4, result);
        }
    }
}
