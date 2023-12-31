﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023.Tests;

public class Day4Tests
{
    [Theory]
    [InlineData("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53", 8)]
    [InlineData("Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19", 2)]
    [InlineData("Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1", 2)]
    [InlineData("Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83", 1)]
    [InlineData("Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36", 0)]
    [InlineData("Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11", 0)]
    [InlineData(Day4.TestInput, 13)]
    [InlineData(Day4.ChallengeInput, 22897)]
    public void SolveFirstChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day4.SolveFirstChallenge(input);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData("""
Card   1: 41 48 83 86 17 |  1  2  3  4  5  6
""", 1)]
    [InlineData("""
Card 1: 41 48 83 86 17 |  1  2  3  4  5 17
Card 2: 41 48 83 86 17 |  1  2  3  4  5  6
""", 3)]
    [InlineData("""
Card 1: 41 48 83 86 17 |  1  2  3  4  5 17
Card 2: 41 48 83 86 17 |  1  2  3  4  5  6
Card 3: 41 48 83 86 17 |  1  2  3  4  5  6
""", 4)]
    [InlineData("""
Card 1: 41 48 83 86 17 |  1  2  3  4 86 17
Card 2: 41 48 83 86 17 |  1  2  3  4  5  6
Card 3: 41 48 83 86 17 |  1  2  3  4  5  6
""", 5)]
    [InlineData("""
Card 1: 41 48 83 86 17 |  1  2  3  4 86 17
Card 2: 41 48 83 86 17 |  1  2  3  4  5 17
Card 3: 41 48 83 86 17 |  1  2  3  4  5  6
""", 7)]
    [InlineData(Day4.TestInput, 30)]
    [InlineData(Day4.ChallengeInput, 5095824)]
    public void SolveSecondChallenge_WhenCalled_ReturnExpectedValue(string input, int expected)
    {
        int actual = Day4.SolveSecondChallenge(input);

        actual.Should().Be(expected);
    }
}
