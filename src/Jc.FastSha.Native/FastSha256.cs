using System.Runtime.InteropServices;
using System.Security;

namespace Jc.FastSha.Native;

public class FastSha256
{
    [SuppressUnmanagedCodeSecurity]
    [DllImport("Jc.FastSha.Zig.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe void computeHash(byte[] data, int length, byte* output);

    public byte[] ComputeHash(ReadOnlySpan<byte> data)
    {
        Span<byte> buffer = stackalloc byte[32];
        ComputeHash(data, buffer);

        return buffer.ToArray();
    }

    public void ComputeHash(ReadOnlySpan<byte> data, Span<byte> buffer)
    {
        unsafe
        {
            fixed (byte* ptr = buffer)
            {
                computeHash(data.ToArray(), data.Length, ptr);
            }
        }
    }
}