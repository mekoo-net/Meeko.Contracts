using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

/// <summary>
/// 一回合内单次模型调用的原始用量。倍率 / 基线 / 金额换算全在平台侧，网关只报原始数。
/// <list type="bullet">
///   <item><see cref="Unit"/> = token：用 <see cref="PromptTokens"/> / <see cref="CompletionTokens"/>；</item>
///   <item>其他单位（image / audio_second / video_second）：用 <see cref="Quantity"/>（张数 / 秒数）。</item>
/// </list>
/// </summary>
[MessagePackObject]
public sealed class TavernModelUsage
{
    [Key(0)] public string ModelName { get; set; } = string.Empty;
    [Key(1)] public string? VendorKey { get; set; }
    [Key(2)] public int PromptTokens { get; set; }
    [Key(3)] public int CompletionTokens { get; set; }
    /// <summary>调用类别（<see cref="TavernUsageKinds"/>）：主对话 / 唤醒判定 / embedding / 媒体生成。</summary>
    [Key(4)] public string Kind { get; set; } = TavernUsageKinds.Chat;
    /// <summary>计量单位（<see cref="TavernUsageUnits"/>），决定平台用哪条基线定价。</summary>
    [Key(5)] public string Unit { get; set; } = TavernUsageUnits.Token;
    /// <summary>非 token 单位的用量（张数 / 秒数）；<see cref="Unit"/> = token 时忽略。</summary>
    [Key(6)] public decimal Quantity { get; set; }
}

/// <summary>回合内模型调用类别常量。</summary>
public static class TavernUsageKinds
{
    public const string Chat = "chat";
    public const string Wake = "wake";
    public const string Embedding = "embedding";
    /// <summary>图片 / 语音 / 视频等媒体生成调用。</summary>
    public const string Generation = "generation";
}

/// <summary>计量单位常量；平台基线表（tavern_settings 的 metering_pricing）按此 key 定价。</summary>
public static class TavernUsageUnits
{
    public const string Token = "token";
    public const string Image = "image";
    public const string AudioSecond = "audio_second";
    public const string VideoSecond = "video_second";
}
