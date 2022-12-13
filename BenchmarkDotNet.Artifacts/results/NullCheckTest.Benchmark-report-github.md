``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2


```
|                      Method |       Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|---------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|                  UsualCheck |   3.482 ns | 0.0325 ns | 0.0288 ns |    1 |      - |         - |
|              ExtensionCheck |   3.879 ns | 0.0210 ns | 0.0197 ns |    2 |      - |         - |
|              AttributeCheck |   4.037 ns | 0.0193 ns | 0.0172 ns |    3 |      - |         - |
| ExtensionWithoutCallerCheck |   4.067 ns | 0.0176 ns | 0.0147 ns |    3 |      - |         - |
|                  GuardCheck | 236.311 ns | 1.7190 ns | 1.5239 ns |    4 | 0.1411 |     592 B |
