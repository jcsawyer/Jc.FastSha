using System.Text;

namespace Jc.FastSha.Tests;

internal static class Utils
{
    internal static byte[] StringToByteArray(string hex)
    {
        if (hex.Length % 2 == 1)
            throw new Exception("The binary key cannot have an odd number of digits");

        var arr = new byte[hex.Length >> 1];
        for (int i = 0; i < hex.Length >> 1; ++i)
        {
            arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
        }

        return arr is [0] ? Array.Empty<byte>() : arr;
    }

    private static int GetHexVal(char hex)
    {
        var val = (int)hex;
        return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
    }

    internal static string HashToString(byte[] bytes)
    {
        var builder = new StringBuilder(bytes.Length * 2);
        foreach (var t in bytes)
        {
            builder.Append($"{t:x2}");
        }

        return builder.ToString();
    }
}