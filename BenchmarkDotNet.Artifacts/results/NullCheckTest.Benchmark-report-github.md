``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2


```
|                      Method |       Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|---------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|              AttributeCheck |   1.999 ns | 0.0309 ns | 0.0274 ns |    1 |      - |         - |
|       CodeAnalysisAttribute |   2.116 ns | 0.0171 ns | 0.0160 ns |    2 |      - |         - |
|               ContractCheck |   2.139 ns | 0.0188 ns | 0.0176 ns |    2 |      - |         - |
|              ExtensionCheck |   3.140 ns | 0.0160 ns | 0.0133 ns |    3 |      - |         - |
|                  UsualCheck |   3.244 ns | 0.0205 ns | 0.0192 ns |    4 |      - |         - |
| ExtensionWithoutCallerCheck |   3.375 ns | 0.0287 ns | 0.0269 ns |    5 |      - |         - |
|                UsualIfCheck |   3.412 ns | 0.0189 ns | 0.0177 ns |    5 |      - |         - |
|              DawnGuardCheck |  17.099 ns | 0.1443 ns | 0.1205 ns |    6 | 0.0191 |      80 B |
|                  ClawsCheck |  24.914 ns | 0.0851 ns | 0.0711 ns |    7 | 0.0382 |     160 B |
|                  GuardCheck | 238.244 ns | 2.2082 ns | 2.0655 ns |    8 | 0.1411 |     592 B |
