``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.403
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT AVX2


```
|                      Method |       Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|---------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|              AttributeCheck |   1.991 ns | 0.0144 ns | 0.0135 ns |    1 |      - |         - |
|               ContractCheck |   2.005 ns | 0.0244 ns | 0.0216 ns |    1 |      - |         - |
|       CodeAnalysisAttribute |   2.153 ns | 0.0248 ns | 0.0220 ns |    2 |      - |         - |
|              ExtensionCheck |   3.182 ns | 0.0181 ns | 0.0151 ns |    3 |      - |         - |
|                  UsualCheck |   3.281 ns | 0.0418 ns | 0.0391 ns |    4 |      - |         - |
| ExtensionWithoutCallerCheck |   3.431 ns | 0.0254 ns | 0.0212 ns |    5 |      - |         - |
|              DawnGuardCheck |  17.223 ns | 0.1943 ns | 0.1818 ns |    6 | 0.0191 |      80 B |
|                  ClawsCheck |  25.353 ns | 0.3055 ns | 0.2551 ns |    7 | 0.0382 |     160 B |
|                  GuardCheck | 222.433 ns | 1.7686 ns | 1.6544 ns |    8 | 0.1414 |     592 B |
