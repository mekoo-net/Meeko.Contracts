using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class WechatPayAppConfig
{
    [Key(0)] public string? AppId { get; set; }
    [Key(1)] public string? MerchantId { get; set; }
    [Key(2)] public string? MerchantSerialNo { get; set; }
}
