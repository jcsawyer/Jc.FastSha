using BenchmarkDotNet.Running;
using Jc.FastSha.Benchmarks;

var summary = BenchmarkRunner.Run<Sha256>();
