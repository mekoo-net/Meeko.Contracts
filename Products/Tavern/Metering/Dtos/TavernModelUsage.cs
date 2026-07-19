using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

/// <summary>
/// 一回合内单次模型调用的原始用量。倍率 / 基线 / 金额换算全在平台侧，网关只报原始数。
/// Kind / Unit 常量与 OneApi.Common（<c>UsageKinds</c> / <c>UsageUnits</c>）对齐；
/// wire 字段仍保留 PromptTokens / CompletionTokens 命名以兼容既有 RPC。
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

/// <summary>回合内模型调用类别常量（与 OneApi.Common <see cref="OneApi.Common.Usage.UsageKinds"/> 对齐；Generation 为媒体类 commit 聚合）。</summary>
public static class TavernUsageKinds
{
    public const string Chat = "chat";
    public const string Wake = "wake";
    public const string Embedding = "embedding";
    /// <summary>图片 / 语音 / 视频等媒体生成调用（与 OneApi.Common UsageKinds.TavernGeneration 同源，值须保持 "generation"）。</summary>
    public const string Generation = "generation";
}

/// <summary>计量单位常量（与 OneApi.Common <see cref="OneApi.Common.Usage.UsageUnits"/> 对齐）。</summary>
public static class TavernUsageUnits
{
    public const string Token = "token";
    public const string Image = "image";
    public const string AudioSecond = "audio_second";
    public const string VideoSecond = "video_second";
}
