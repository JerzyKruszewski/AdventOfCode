namespace AoC2023.Benchmarks;

[MemoryDiagnoser]
public class Day3Benchmarks
{
    /*
CPU:    AMD Ryzen 9 7950X, 4.5 GHz, 64 MB   (SINGLE THREAD)
RAM:    DDR5, 64 GB, 5600MHz, CL40
OS:     WINDOWS 10 HOME 64-bit

| Method                    | Mean        | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|-------------------------- |------------:|----------:|----------:|-------:|-------:|----------:|
| FirstChallengeTestData    |    527.0 ns |   3.61 ns |   3.37 ns | 0.1116 |      - |   1.84 KB |
| FirstChallengeActualData  | 73,924.8 ns | 494.47 ns | 438.33 ns | 5.4932 | 0.7324 |  90.89 KB |
| SecondChallengeTestData   |    678.1 ns |   3.94 ns |   3.68 ns | 0.1173 |      - |   1.93 KB |
| SecondChallengeActualData | 95,404.7 ns | 421.01 ns | 373.21 ns | 6.3477 | 0.9766 | 103.73 KB |
    */

    [Benchmark]    
    public void FirstChallengeTestData()
    {
        _ = Day3.SolveFirstChallenge(Day3.TestInput);
    }

    [Benchmark]
    public void FirstChallengeActualData()
    {
        _ = Day3.SolveFirstChallenge(Day3.ChallengeInput);
    }

    [Benchmark]
    public void SecondChallengeTestData()
    {
        _ = Day3.SolveSecondChallenge(Day3.TestInput);
    }

    [Benchmark]
    public void SecondChallengeActualData()
    {
        _ = Day3.SolveSecondChallenge(Day3.ChallengeInput);
    }
}
