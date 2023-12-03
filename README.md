# AdventOfCode
My take on AdventOfCode challenges

# Benchmarks

## System parameters

```
CPU:    AMD Ryzen 9 7950X, 4.5 GHz, 64 MB
RAM:    DDR5, 64 GB, 5600MHz, CL40
OS:     WINDOWS 10 HOME 64-bit
```

## 2023

### Day 1

| Method                    | Mean          | Error      | StdDev     | Gen0     | Gen1    | Allocated |
|-------------------------- |--------------:|-----------:|-----------:|---------:|--------:|----------:|
| FirstChallengeTestData    |      56.85 ns |   0.120 ns |   0.106 ns |   0.0162 |       - |     272 B |
| FirstChallengeActualData  |  18,154.98 ns | 296.494 ns | 277.341 ns |   4.6082 |  1.0071 |   77152 B |
| SecondChallengeTestData   |   1,083.55 ns |   1.573 ns |   1.395 ns |   0.4387 |       - |    7368 B |
| SecondChallengeActualData | 271,931.32 ns | 419.029 ns | 371.459 ns | 109.8633 | 27.3438 | 1845219 B |

***

### Day 2

| Method                    | Mean      | Error     | StdDev    | Gen0    | Gen1   | Allocated |
|-------------------------- |----------:|----------:|----------:|--------:|-------:|----------:|
| FirstChallengeTestData    |  1.981 us | 0.0257 us | 0.0215 us |  0.4730 |      - |   7.75 KB |
| FirstChallengeActualData  | 53.934 us | 0.3408 us | 0.3021 us | 12.5732 | 1.0376 | 205.62 KB |
| SecondChallengeTestData   |  2.250 us | 0.0138 us | 0.0129 us |  0.5226 |      - |   8.59 KB |
| SecondChallengeActualData | 75.651 us | 1.2597 us | 1.1783 us | 15.9912 | 1.3428 | 262.59 KB |

***

### Day 3

| Method                    | Mean        | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|-------------------------- |------------:|----------:|----------:|-------:|-------:|----------:|
| FirstChallengeTestData    |    527.0 ns |   3.61 ns |   3.37 ns | 0.1116 |      - |   1.84 KB |
| FirstChallengeActualData  | 73,924.8 ns | 494.47 ns | 438.33 ns | 5.4932 | 0.7324 |  90.89 KB |
| SecondChallengeTestData   |    678.1 ns |   3.94 ns |   3.68 ns | 0.1173 |      - |   1.93 KB |
| SecondChallengeActualData | 95,404.7 ns | 421.01 ns | 373.21 ns | 6.3477 | 0.9766 | 103.73 KB |

***
