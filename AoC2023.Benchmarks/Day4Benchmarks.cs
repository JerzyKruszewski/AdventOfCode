namespace AoC2023.Benchmarks;

[MemoryDiagnoser]
public class Day4Benchmarks
{
    /*
CPU:    AMD Ryzen 9 7950X, 4.5 GHz, 64 MB   (SINGLE THREAD)
RAM:    DDR5, 64 GB, 5600MHz, CL40
OS:     WINDOWS 10 HOME 64-bit

| Method                    | Mean       | Error     | StdDev    | Gen0    | Gen1    | Allocated |
|-------------------------- |-----------:|----------:|----------:|--------:|--------:|----------:|
| FirstChallengeTestData    |   2.460 us | 0.0482 us | 0.0451 us |  0.6142 |       - |  10.05 KB |
| FirstChallengeActualData  | 186.039 us | 3.0212 us | 2.8260 us | 42.2363 |  8.0566 | 690.71 KB |
| SecondChallengeTestData   |   2.769 us | 0.0343 us | 0.0321 us |  0.6981 |  0.0038 |  11.46 KB |
| SecondChallengeActualData | 208.729 us | 2.7336 us | 2.5570 us | 45.1660 | 14.4043 | 740.78 KB |
    */

    [Benchmark]    
    public void FirstChallengeTestData()
    {
        _ = Day4.SolveFirstChallenge(Day4.TestInput);
    }

    [Benchmark]
    public void FirstChallengeActualData()
    {
        _ = Day4.SolveFirstChallenge(Day4.ChallengeInput);
    }

    [Benchmark]
    public void SecondChallengeTestData()
    {
        _ = Day4.SolveSecondChallenge(Day4.TestInput);
    }

    [Benchmark]
    public void SecondChallengeActualData()
    {
        _ = Day4.SolveSecondChallenge(Day4.ChallengeInput);
    }
}
