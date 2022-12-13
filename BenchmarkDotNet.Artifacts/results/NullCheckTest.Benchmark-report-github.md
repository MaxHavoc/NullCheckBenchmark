``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2


```
|                                 Method |       Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|--------------------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|                         AttributeCheck |   2.012 ns | 0.0221 ns | 0.0185 ns |    1 |      - |         - |
|                         ExtensionCheck |   3.044 ns | 0.0415 ns | 0.0388 ns |    2 |      - |         - |
|            ExtensionWithoutCallerCheck |   3.464 ns | 0.0466 ns | 0.0413 ns |    3 |      - |         - |
|                  UsualCheck_NoInlining |   3.525 ns | 0.0229 ns | 0.0203 ns |    4 |      - |         - |
|                             UsualCheck |   3.552 ns | 0.1010 ns | 0.1037 ns |    4 |      - |         - |
| ExtensionWithoutCallerCheck_NoInlining |   3.563 ns | 0.0352 ns | 0.0312 ns |    4 |      - |         - |
|              AttributeCheck_NoInlining |   3.630 ns | 0.0357 ns | 0.0334 ns |    5 |      - |         - |
|              ExtensionCheck_NoInlining |   3.740 ns | 0.0311 ns | 0.0291 ns |    6 |      - |         - |
|                  GuardCheck_NoInlining | 239.153 ns | 1.6046 ns | 1.5010 ns |    7 | 0.1411 |     592 B |
|                             GuardCheck | 243.153 ns | 1.4503 ns | 1.2857 ns |    8 | 0.1411 |     592 B |
