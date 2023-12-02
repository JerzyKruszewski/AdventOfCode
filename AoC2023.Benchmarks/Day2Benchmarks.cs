namespace AoC2023.Benchmarks;

[MemoryDiagnoser]
public class Day2Benchmarks
{
    /*
CPU:    AMD Ryzen 9 7950X, 4.5 GHz, 64 MB   (SINGLE THREAD)
RAM:    DDR5, 64 GB, 5600MHz, CL40
OS:     WINDOWS 10 HOME 64-bit

| Method                    | Mean      | Error     | StdDev    | Gen0    | Gen1   | Allocated |
|-------------------------- |----------:|----------:|----------:|--------:|-------:|----------:|
| FirstChallengeTestData    |  1.981 us | 0.0257 us | 0.0215 us |  0.4730 |      - |   7.75 KB |
| FirstChallengeActualData  | 53.934 us | 0.3408 us | 0.3021 us | 12.5732 | 1.0376 | 205.62 KB |
| SecondChallengeTestData   |  2.250 us | 0.0138 us | 0.0129 us |  0.5226 |      - |   8.59 KB |
| SecondChallengeActualData | 75.651 us | 1.2597 us | 1.1783 us | 15.9912 | 1.3428 | 262.59 KB |
    */

    [Benchmark]    
    public void FirstChallengeTestData()
    {
        _ = Day2.SolveFirstChallenge(Day2.TestInput, 13, 14, 12);
    }

    [Benchmark]
    public void FirstChallengeActualData()
    {
        _ = Day2.SolveFirstChallenge(Day2.ChallengeInput, 13, 14, 12);
    }

    [Benchmark]
    public void SecondChallengeTestData()
    {
        _ = Day2.SolveSecondChallenge(Day2.TestInput);
    }

    [Benchmark]
    public void SecondChallengeActualData()
    {
        _ = Day2.SolveSecondChallenge(Day2.ChallengeInput);
    }
}
