using MagicOnion;
using MessagePack;
using Platform.Common.Web;
using System.Text.Json.Serialization;

namespace Meeko.Contracts.Keystone;

public interface IKeystonePlatformApiKeyService : IService<IKeystonePlatformApiKeyService>
{
    UnaryResult<PlatformApiKeyListResult> ListAsync(ListPlatformApiKeysQuery query);
    UnaryResult<IssuePlatformApiKeyResult> IssueAsync(IssuePlatformApiKeyCommand cmd);
    UnaryResult<UpdatePlatformApiKeyResult> UpdateAsync(UpdatePlatformApiKeyCommand cmd);
    UnaryResult<PlatformApiKeyCommandResult> RevokeAsync(RevokePlatformApiKeyCommand cmd);
    /// <summary>可开通的 Staff 权限码（与角色目录同一份）。</summary>
    UnaryResult<string[]> ListScopeCatalogAsync();
}

[MessagePackObject]
public sealed class ListPlatformApiKeysQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;
}

[MessagePackObject]
public sealed class PlatformApiKeyDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)] public string Name { get; set; } = string.Empty;
    [Key(2)] public string KeyHint { get; set; } = string.Empty;
    /// <summary>已开通的 Staff 权限码。</summary>
    [Key(3)] public string[] Scopes { get; set; } = [];
    [Key(4)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long IssuedByStaffUid { get; set; }

    [Key(5)] public DateTime? ExpiresAtUtc { get; set; }
    [Key(6)] public DateTime? RevokedAtUtc { get; set; }
    [Key(7)] public DateTime? LastUsedAtUtc { get; set; }
    [Key(8)] public DateTime CreatedAtUtc { get; set; }
    /// <summary>明文；旧令牌未保存时为 null。</summary>
    [Key(9)] public string? Plaintext { get; set; }
}

[MessagePackObject]
public sealed class PlatformApiKeyListResult
{
    [Key(0)] public required PlatformApiKeyDto[] Items { get; set; }
    [Key(1)] public required int Total { get; set; }
}

[MessagePackObject]
public sealed class IssuePlatformApiKeyCommand
{
    [Key(0)] public string Name { get; set; } = string.Empty;
    /// <summary>要开通的 Staff 权限码。</summary>
    [Key(1)] public string[] Scopes { get; set; } = [];
    [Key(2)] public DateTime? ExpiresAtUtc { get; set; }
    [Key(3)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long OperatorStaffUid { get; set; }
}

[MessagePackObject]
public sealed class IssuePlatformApiKeyResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public string? FailureCode { get; set; }
    [Key(2)] public string? FailureMessage { get; set; }
    [Key(3)] public PlatformApiKeyDto? Key { get; set; }
    [Key(4)] public string? Plaintext { get; set; }

    public static IssuePlatformApiKeyResult Ok(PlatformApiKeyDto key, string plaintext)
        => new() { Success = true, Key = key, Plaintext = plaintext };

    public static IssuePlatformApiKeyResult Fail(string code, string message)
        => new() { Success = false, FailureCode = code, FailureMessage = message };
}

[MessagePackObject]
public sealed class UpdatePlatformApiKeyCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long KeyId { get; set; }

    /// <summary>要开通的 Staff 权限码（整表替换）。</summary>
    [Key(1)] public string[] Scopes { get; set; } = [];

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long OperatorStaffUid { get; set; }
}

[MessagePackObject]
public sealed class UpdatePlatformApiKeyResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public string? FailureCode { get; set; }
    [Key(2)] public string? FailureMessage { get; set; }
    [Key(3)] public PlatformApiKeyDto? Key { get; set; }

    public static UpdatePlatformApiKeyResult Ok(PlatformApiKeyDto key)
        => new() { Success = true, Key = key };

    public static UpdatePlatformApiKeyResult Fail(string code, string message)
        => new() { Success = false, FailureCode = code, FailureMessage = message };
}

[MessagePackObject]
public sealed class RevokePlatformApiKeyCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long KeyId { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long OperatorStaffUid { get; set; }
}

[MessagePackObject]
public sealed class PlatformApiKeyCommandResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public string? FailureCode { get; set; }
    [Key(2)] public string? FailureMessage { get; set; }

    public static PlatformApiKeyCommandResult Ok() => new() { Success = true };

    public static PlatformApiKeyCommandResult Fail(string code, string message)
        => new() { Success = false, FailureCode = code, FailureMessage = message };
}

