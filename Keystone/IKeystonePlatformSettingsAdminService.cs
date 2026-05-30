using MessagePack;
using MagicOnion;

namespace Meeko.Contracts.Keystone;

public interface IKeystonePlatformSettingsAdminService : IService<IKeystonePlatformSettingsAdminService>
{
    UnaryResult<PlatformAuthSettingsAdminWireDto> GetAuthSettingsAsync();

    UnaryResult<PlatformAuthSettingsAdminWireDto> UpdateAuthSettingsAsync(UpdatePlatformAuthSettingsWireCommand cmd);

    UnaryResult<PlatformEmailSettingsAdminWireDto> GetEmailSettingsAsync();

    UnaryResult<PlatformEmailSettingsAdminWireDto> UpdateEmailSettingsAsync(UpdatePlatformEmailSettingsWireCommand cmd);
}

[MessagePackObject]
public sealed class PlatformAuthSettingsAdminWireDto
{
    [Key(0)] public bool RegistrationEnabled { get; set; }
    [Key(1)] public bool PasswordLogin { get; set; }
    [Key(2)] public string RegistrationChannel { get; set; } = "email";
    [Key(3)] public bool CaptchaEnabled { get; set; }
    [Key(4)] public string CaptchaProvider { get; set; } = "none";
    [Key(5)] public string CaptchaSiteKey { get; set; } = string.Empty;
    [Key(6)] public bool CaptchaSecretConfigured { get; set; }
    [Key(7)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class UpdatePlatformAuthSettingsWireCommand
{
    [Key(0)] public bool? RegistrationEnabled { get; set; }
    [Key(1)] public bool? PasswordLogin { get; set; }
    [Key(2)] public string? RegistrationChannel { get; set; }
    [Key(3)] public bool? CaptchaEnabled { get; set; }
    [Key(4)] public string? CaptchaProvider { get; set; }
    [Key(5)] public string? CaptchaSiteKey { get; set; }
    [Key(6)] public string? CaptchaSecretKey { get; set; }
}

[MessagePackObject]
public sealed class PlatformEmailSettingsAdminWireDto
{
    [Key(0)] public bool EmailSuffixRestrictionEnabled { get; set; }
    [Key(1)] public string[] AllowedEmailSuffixes { get; set; } = [];
    [Key(2)] public bool VerificationCodeEnabled { get; set; }
    [Key(3)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class UpdatePlatformEmailSettingsWireCommand
{
    [Key(0)] public bool? EmailSuffixRestrictionEnabled { get; set; }
    [Key(1)] public string[]? AllowedEmailSuffixes { get; set; }
    [Key(2)] public bool? VerificationCodeEnabled { get; set; }
}
