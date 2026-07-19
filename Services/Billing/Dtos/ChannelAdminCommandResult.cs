using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ChannelAdminCommandResult
{
    [Key(0)] public required bool Success { get; set; }
    [Key(1)] public PaymentChannelDto? Channel { get; set; }
    [Key(2)] public string? FailureCode { get; set; }
    [Key(3)] public string? FailureMessage { get; set; }

    public static ChannelAdminCommandResult Ok(PaymentChannelDto channel) =>
        new() { Success = true, Channel = channel };

    public static ChannelAdminCommandResult Fail(string code, string message) =>
        new() { Success = false, FailureCode = code, FailureMessage = message };
}
