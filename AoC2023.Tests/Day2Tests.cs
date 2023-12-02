using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023.Tests;

public class Day2Tests
{
    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 13, 14, 12, 1)]
    [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 13, 14, 12, 2)]
    [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 13, 14, 12, 0)]
    [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 13, 14, 12, 0)]
    [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 13, 14, 12, 5)]
    [InlineData("""
        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
        """, 13, 14, 12, 0)]
    [InlineData("""
        Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
        """, 13, 14, 12, 1)]
    [InlineData("""
        Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
        """, 13, 14, 12, 3)]
    [InlineData(Day2.TestInput, 13, 14, 12, 8)]
    [InlineData(Day2.ChallengeInput, 13, 14, 12, 2164)]
    public void SolveFirstChallenge_WhenCalled_ReturnExpectedValue(string input, int maxGreen, int maxBlue, int maxRed, int expected)
    {
        int actual = Day2.SolveFirstChallenge(input, maxGreen, maxBlue, maxRed);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 48)]
    [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 12)]
    [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 1560)]
    [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 630)]
    [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 36)]
    [InlineData(Day2.TestInput, 2286)]
    [InlineData(Day2.ChallengeInput, 69929)]
    public void SolveSecondChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day2.SolveSecondChallenge(input);

        actual.Should().Be(expected);
    }
}
