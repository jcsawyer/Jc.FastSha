const std = @import("std");
const Sha256 = std.crypto.hash.sha2.Sha256;

export fn computeHash(data: [*]u8, length: c_int, buffer: *[Sha256.digest_length]u8) callconv(.C) void {
    var sha256 = Sha256.init(.{});
    sha256.update(data[0..@intCast(length)]);

    buffer.* = sha256.finalResult();
}

test "computeHash should compute correct hash for empty string" {
    try assertEqualHash("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", "");
}

test "computeHash should compute correct hash for abc" {
    try assertEqualHash("ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad", "abc");
}

fn assertEqualHash(comptime expected_hex: *const [Sha256.digest_length * 2:0]u8, comptime input: []const u8) !void {
    var hash: [Sha256.digest_length]u8 = undefined;
    var data: [input.len]u8 = undefined;
    _ = std.mem.copy(u8, data[0..], input);

    computeHash(&data, input.len, &hash);

    var expected_bytes: [expected_hex.len / 2]u8 = undefined;
    for (&expected_bytes, 0..) |*r, i| {
        r.* = std.fmt.parseInt(u8, expected_hex[2 * i .. 2 * i + 2], 16) catch unreachable;
    }

    try std.testing.expectEqualSlices(u8, &expected_bytes, &hash);
}
