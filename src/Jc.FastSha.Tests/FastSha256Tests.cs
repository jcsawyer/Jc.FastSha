using Jc.FastSha.Tests.Data;

namespace Jc.FastSha.Tests;

[TestFixture]
internal sealed class FastSha256Tests
{
    private FastSha256 _subject = null!;

    [SetUp]
    public void SetUp()
    {
        _subject = new FastSha256();
    }

    [TestCaseSource(typeof(Sha256CavsByteShortMsg), nameof(Sha256CavsByteShortMsg.TestCases))]
    public string ComputeHashCavs11ShortByteMessages(byte[] data)
    {
        var hash = _subject.ComputeHash(data);
        return Utils.HashToString(hash);
    }

    [TestCaseSource(typeof(Sha256CavsByteLongMsg), nameof(Sha256CavsByteLongMsg.TestCases))]
    public string ComputeHashCavs11LongByteMessages(byte[] data)
    {
        var hash = _subject.ComputeHash(data);
        return Utils.HashToString(hash);
    }
    
    [TestCaseSource(typeof(Sha256CavsByteShortMsg), nameof(Sha256CavsByteShortMsg.TestCases))]
    public string ComputeHashSpanCavs11ShortByteMessages(byte[] data)
    {
        Span<byte> buffer = stackalloc byte[32];

        _subject.ComputeHash(data, buffer);

        return Utils.HashToString(buffer.ToArray());
    }
    
    [TestCaseSource(typeof(Sha256CavsByteLongMsg), nameof(Sha256CavsByteLongMsg.TestCases))]
    public string ComputeHashSpanCavs11LongByteMessages(byte[] data)
    {
        Span<byte> buffer = stackalloc byte[32];

        _subject.ComputeHash(data, buffer);

        return Utils.HashToString(buffer.ToArray());
    }
}