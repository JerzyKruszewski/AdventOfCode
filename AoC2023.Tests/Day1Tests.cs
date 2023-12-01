namespace AoC2023.Tests;

public class Day1Tests
{
    [Theory]
    [InlineData(Day1.TestInput, 142)]
    [InlineData(Day1.ChallengeInput, 54338)]
    public void SolveFirstChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day1.SolveFirstChallenge(input);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(Day1.TestInput, 142)]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    [InlineData(Day1.Test2Input, 281)]
    [InlineData(Day1.ChallengeInput, 53389)]
    public void SolveSecondChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day1.SolveSecondChallenge(input);

        actual.Should().Be(expected);
    }
}
