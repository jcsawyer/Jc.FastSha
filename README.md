# Jc.FastSha
A fast(ish) SHA-2 (256) implementation in C#.

Built as a challenge to myself after unearthing my original SHA256 implementation I wrote for a challenge when I was an apprentice many years ago.

For anyone interested, more details available on [my blog post](https://jcsawyer.com/blog/2024/03/16/revisting-sha256/).

## Benchmarks
```
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.1778/22H2/2022Update/SunValley2)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.201
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```
| Method                     | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| SystemSecurityCryptography | 405.9 ns | 5.42 ns | 4.23 ns |  1.00 | 0.0176 |     112 B |        1.00 |
| JcFastSha256               | 387.2 ns | 3.28 ns | 2.91 ns |  0.95 | 0.0086 |      56 B |        0.50 |
| JcFastSha256Span           | 381.9 ns | 4.46 ns | 3.95 ns |  0.94 |      - |         - |        0.00 |
