``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2


```
|                                 Method |       Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|--------------------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|                         AttributeCheck |   1.949 ns | 0.0170 ns | 0.0159 ns |    1 |      - |         - |
|                         ExtensionCheck |   3.208 ns | 0.0708 ns | 0.0662 ns |    2 |      - |         - |
|            ExtensionWithoutCallerCheck |   3.336 ns | 0.0408 ns | 0.0362 ns |    3 |      - |         - |
|                             UsualCheck |   3.463 ns | 0.0552 ns | 0.0517 ns |    4 |      - |         - |
|              AttributeCheck_NoInlining |   3.467 ns | 0.0553 ns | 0.0490 ns |    4 |      - |         - |
| ExtensionWithoutCallerCheck_NoInlining |   3.524 ns | 0.0205 ns | 0.0171 ns |    5 |      - |         - |
|              ExtensionCheck_NoInlining |   3.750 ns | 0.0181 ns | 0.0161 ns |    6 |      - |         - |
|                  UsualCheck_NoInlining |   3.859 ns | 0.0281 ns | 0.0263 ns |    7 |      - |         - |
|              DawnGuardCheck_NoInlining |  16.608 ns | 0.1553 ns | 0.1377 ns |    8 | 0.0191 |      80 B |
|                         DawnGuardCheck |  17.281 ns | 0.0883 ns | 0.0738 ns |    9 | 0.0191 |      80 B |
|                             ClawsCheck |  25.705 ns | 0.5308 ns | 1.0477 ns |   10 | 0.0382 |     160 B |
|                  ClawsCheck_NoInlining |  25.902 ns | 0.1209 ns | 0.0944 ns |   10 | 0.0382 |     160 B |
|                  GuardCheck_NoInlining | 233.913 ns | 1.6325 ns | 1.3633 ns |   11 | 0.1414 |     592 B |
|                             GuardCheck | 234.678 ns | 1.8620 ns | 1.4537 ns |   11 | 0.1411 |     592 B |
