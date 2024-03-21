# Jc.FastSha
A fast(ish) SHA-2 (256) implementation in C#.

This implementation is entirely in managed code and only has a chance at being more performance than `System.Security.Cryptography` for very small data to offset the overhead of its native calls.  

Built as a challenge to myself after unearthing my original SHA256 implementation I wrote for a challenge when I was an apprentice many years ago.

More details of what and why can be found on my blog posts:
- [Revisiting an old SHA256 implementation](https://jcsawyer.com/blog/2024/03/16/revisting-sha256/)
- [Calling Zig from C# with Jc.FastSha.Native](https://jcsawyer.com/blog/2024/03/18/calling-zig-from-csharp-with-jc-fastsha-native/)

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
| JcFastSha256Native         | 228.6 ns | 3.28 ns | 3.06 ns |  0.56 | 0.0138 |      88 B |        0.79 |
