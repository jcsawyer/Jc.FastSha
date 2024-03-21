using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

namespace Jc.FastSha.Benchmarks;

[MemoryDiagnoser]
public class Sha256
{
    // "test" UTF8 encoded
    private static readonly byte[] Data = [0x74, 0x65, 0x73, 0x74];

    private readonly SHA256 _sha256 = SHA256.Create();
    private readonly FastSha256 _fastSha256 = new();
    private readonly Native.FastSha256 _fastSha256Native = new();
    private readonly Memory<byte> _buffer = new(Hash);
    private static readonly byte[] Hash = new byte[32];
    
    [Benchmark(Baseline = true)]
    public byte[] SystemSecurityCryptography() => _sha256.ComputeHash(Data);

    [Benchmark]
    public byte[] JcFastSha256() => _fastSha256.ComputeHash(Data);

    [Benchmark]
    public void JcFastSha256Span() => _fastSha256.ComputeHash(Data, _buffer.Span);
    
    [Benchmark]
    public byte[] JcFastSha256Native() => _fastSha256Native.ComputeHash(Data);
}