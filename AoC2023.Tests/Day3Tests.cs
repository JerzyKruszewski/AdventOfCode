using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023.Tests;

public class Day3Tests
{
    [Theory]
    [InlineData("*114", 114)]
    [InlineData("467*.114..", 467)]
    [InlineData("467.*114..", 114)]
    [InlineData("""
....*.....
12345..890
""", 12345)]
    [InlineData("""
12345..890
....*.....
""", 12345)]
    [InlineData(".........426.............985.........40..........207............................841..463................................633........17.384...", 0)]
    [InlineData("*", 0)]
    [InlineData(Day3.TestInput, 4361)]
    [InlineData(Day3.ChallengeInput, 546312)]
    public void SolveFirstChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day3.SolveFirstChallenge(input);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(Day3.TestInput, 467835)]
    [InlineData(Day3.ChallengeInput, 87449461)]
    public void SolveSecondChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day3.SolveSecondChallenge(input);

        actual.Should().Be(expected);
    }
}
