using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Jc.FastSha;

public class FastSha256
{
    public byte[] ComputeHash(ReadOnlySpan<byte> data)
    {
        Span<uint> hash = stackalloc uint[8] { H[0], H[1], H[2], H[3], H[4], H[5], H[6], H[7] };
        ComputeHashInternal(data, hash);

        return ToByteArray(hash);
    }

    public void ComputeHash(ReadOnlySpan<byte> data, Span<byte> buffer)
    {
        Span<uint> hash = stackalloc uint[8] { H[0], H[1], H[2], H[3], H[4], H[5], H[6], H[7] };
        ComputeHashInternal(data, hash);

        for (var i = 0; i < hash.Length * 4; i += 4)
        {
            var val = hash[i / 4];
            var span = buffer[i..(i + 4)];
            span[0] = (byte)(val >> 24);
            span[1] = (byte)(val >> 16);
            span[2] = (byte)(val >> 8);
            span[3] = (byte)val;
        }
    }

    private void ComputeHashInternal(ReadOnlySpan<byte> data, Span<uint> hash)
    {
        Span<uint> chunk = stackalloc uint[64];
        
        var offset = 0;
        var count = data.Length;
        var chunks = count / 64;

        while (chunks-- > 0)
        {
            ProcessChunk(hash, chunk, data.Slice(offset, 64));
            offset += 64;
        }

        var remainingBytes = count % 64;
        Span<byte> lastChunk = stackalloc byte[64];
        lastChunk.Clear();
        switch (remainingBytes)
        {
            case 0:
                lastChunk[0] = 0x80;

                BinaryPrimitives.WriteInt64BigEndian(lastChunk.Slice(56, 8), count * 8);

                ProcessChunk(hash, chunk, lastChunk);
                break;
            case 56:
            case 57:
            case 58:
            case 59:
            case 60:
            case 61:
            case 62:
            case 63:
                data.Slice(offset, remainingBytes).CopyTo(lastChunk);
                lastChunk[remainingBytes] = 0x80;
                ProcessChunk(hash, chunk, lastChunk);

                lastChunk.Clear();
                BinaryPrimitives.WriteInt64BigEndian(lastChunk.Slice(56, 8), count * 8);
                ProcessChunk(hash, chunk, lastChunk);
                break;
            default:
                data.Slice(offset, remainingBytes).CopyTo(lastChunk);
                lastChunk[remainingBytes] = 0x80;

                BinaryPrimitives.WriteInt64BigEndian(lastChunk.Slice(56, 8), count * 8);

                ProcessChunk(hash, chunk, lastChunk);
                break;
        }
    }
    
    private static void ProcessChunk(Span<uint> currentHash, Span<uint> chunk, ReadOnlySpan<byte> data)
    {
        FillWords(chunk, data);
        ExpandWords(chunk);
        MungeChunk(currentHash, chunk);
    }

    private static void FillWords(Span<uint> chunk, ReadOnlySpan<byte> data)
    {
        chunk[0] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(0, 4));
        chunk[1] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(4, 4));
        chunk[2] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(8, 4));
        chunk[3] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(12, 4));
        chunk[4] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(16, 4));
        chunk[5] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(20, 4));
        chunk[6] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(24, 4));
        chunk[7] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(28, 4));
        chunk[8] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(32, 4));
        chunk[9] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(36, 4));
        chunk[10] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(40, 4));
        chunk[11] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(44, 4));
        chunk[12] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(48, 4));
        chunk[13] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(52, 4));
        chunk[14] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(56, 4));
        chunk[15] = BinaryPrimitives.ReadUInt32BigEndian(data.Slice(60, 4));
    }

    private static void ExpandWords(Span<uint> chunk)
    {
        for (var i = 16; i < 64; i++)
        {
            chunk[i] = sigma1(chunk[i - 2]) + chunk[i - 7] + sigma0(chunk[i - 15]) + chunk[i - 16];
        }
    }

    private static void MungeChunk(Span<uint> currentHash, Span<uint> chunk)
    {
        Span<uint> workingHash = stackalloc uint[8]
        {
            currentHash[0], currentHash[1], currentHash[2], currentHash[3], currentHash[4], currentHash[5],
            currentHash[6], currentHash[7]
        };

        for (var i = 0; i < 64; i++)
        {
            uint t1 = workingHash[7] + Sigma1(workingHash[4]) + Ch(workingHash[4], workingHash[5], workingHash[6]) +
                      K[i] + chunk[i];
            uint t2 = Sigma0(workingHash[0]) + Maj(workingHash[0], workingHash[1], workingHash[2]);
            workingHash[7] = workingHash[6];
            workingHash[6] = workingHash[5];
            workingHash[5] = workingHash[4];
            workingHash[4] = workingHash[3] + t1;
            workingHash[3] = workingHash[2];
            workingHash[2] = workingHash[1];
            workingHash[1] = workingHash[0];
            workingHash[0] = t1 + t2;
        }

        currentHash[0] += workingHash[0];
        currentHash[1] += workingHash[1];
        currentHash[2] += workingHash[2];
        currentHash[3] += workingHash[3];
        currentHash[4] += workingHash[4];
        currentHash[5] += workingHash[5];
        currentHash[6] += workingHash[6];
        currentHash[7] += workingHash[7];
    }

    private static byte[] ToByteArray(Span<uint> data)
    {
        var result = GC.AllocateUninitializedArray<byte>(32);

        var pos = 0;
        for (var i = 0; i < data.Length; i++)
        {
            var val = data[i];
            result[pos++] = (byte)(val >> 24);
            result[pos++] = (byte)(val >> 16);
            result[pos++] = (byte)(val >> 8);
            result[pos++] = (byte)val;
        }

        return result;
    }

    /// <summary>
    /// K[64] First 32 bits of the fractional parts of the cube roots of the first 64 primes
    /// </summary>
    private static readonly uint[] K =
    [
        0x428A2F98, 0x71374491, 0xB5C0FBCF, 0xE9B5DBA5, 0x3956C25B, 0x59F111F1, 0x923F82A4, 0xAB1C5ED5,
        0xD807AA98, 0x12835B01, 0x243185BE, 0x550C7DC3, 0x72BE5D74, 0x80DEB1FE, 0x9BDC06A7, 0xC19BF174,
        0xE49B69C1, 0xEFBE4786, 0x0FC19DC6, 0x240CA1CC, 0x2DE92C6F, 0x4A7484AA, 0x5CB0A9DC, 0x76F988DA,
        0x983E5152, 0xA831C66D, 0xB00327C8, 0xBF597FC7, 0xC6E00BF3, 0xD5A79147, 0x06CA6351, 0x14292967,
        0x27B70A85, 0x2E1B2138, 0x4D2C6DFC, 0x53380D13, 0x650A7354, 0x766A0ABB, 0x81C2C92E, 0x92722C85,
        0xA2BFE8A1, 0xA81A664B, 0xC24B8B70, 0xC76C51A3, 0xD192E819, 0xD6990624, 0xF40E3585, 0x106AA070,
        0x19A4C116, 0x1E376C08, 0x2748774C, 0x34B0BCB5, 0x391C0CB3, 0x4ED8AA4A, 0x5B9CCA4F, 0x682E6FF3,
        0x748F82EE, 0x78A5636F, 0x84C87814, 0x8CC70208, 0x90BEFFFA, 0xA4506CEB, 0xBEF9A3F7, 0xC67178F2
    ];

    /// <summary>
    /// H[8] Fractional parts of the square roots of first 8 primes
    /// </summary>
    private static readonly uint[] H =
    [
        0x6A09E667, 0xBB67AE85, 0x3C6EF372, 0xA54FF53A, 0x510E527F, 0x9B05688C, 0x1F83D9AB, 0x5BE0CD19
    ];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Rotr(uint x, byte n)
    {
        return (x >> n) | (x << (32 - n));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Ch(uint x, uint y, uint z)
    {
        return (x & y) ^ (~x & z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Maj(uint x, uint y, uint z)
    {
        return (x & y) ^ (x & z) ^ (y & z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Sigma0(uint x)
    {
        return Rotr(x, 2) ^ Rotr(x, 13) ^ Rotr(x, 22);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Sigma1(uint x)
    {
        return Rotr(x, 6) ^ Rotr(x, 11) ^ Rotr(x, 25);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint sigma0(uint x)
    {
        return Rotr(x, 7) ^ Rotr(x, 18) ^ (x >> 3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint sigma1(uint x)
    {
        return Rotr(x, 17) ^ Rotr(x, 19) ^ (x >> 10);
    }
}