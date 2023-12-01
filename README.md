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
