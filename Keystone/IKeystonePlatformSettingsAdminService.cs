using MessagePack;
using MagicOnion;

namespace Meeko.Contracts.Keystone;

public interface IKeystonePlatformSettingsAdminService : IService<IKeystonePlatformSettingsAdminService>
{
    UnaryResult<PlatformAuthSettingsAdminWireDto> GetAuthSettingsAsync();

    UnaryResult<PlatformAuthSettingsAdminWireDto> UpdateAuthSettingsAsync(UpdatePlatformAuthSettingsWireCommand cmd);

    UnaryResult<PlatformEmailSettingsAdminWireDto> GetEmailSettingsAsync();

    UnaryResult<PlatformEmailSettingsAdminWireDto> UpdateEmailSettingsAsync(UpdatePlatformEmailSettingsWireCommand cmd);

    UnaryResult<PlatformReferralSettingsAdminWireDto> GetReferralSettingsAsync();

    UnaryResult<PlatformReferralSettingsAdminWireDto> UpdateReferralSettingsAsync(UpdatePlatformReferralSettingsWireCommand cmd);
}

[MessagePackObject]
public sealed class PlatformAuthSettingsAdminWireDto
{
    [Key(0)] public bool RegistrationEnabled { get; set; }
    [Key(1)] public bool PasswordLogin { get; set; }
    [Key(2)] public string RegistrationChannel { get; set; } = "email";
    [Key(3)] public string CaptchaProvider { get; set; } = "none";
    [Key(4)] public string CaptchaSiteKey { get; set; } = string.Empty;
    [Key(5)] public bool CaptchaSecretConfigured { get; set; }
    [Key(6)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class UpdatePlatformAuthSettingsWireCommand
{
    [Key(0)] public bool? RegistrationEnabled { get; set; }
    [Key(1)] public bool? PasswordLogin { get; set; }
    [Key(2)] public string? RegistrationChannel { get; set; }
    [Key(3)] public string? CaptchaProvider { get; set; }
    [Key(4)] public string? CaptchaSiteKey { get; set; }
    [Key(5)] public string? CaptchaSecretKey { get; set; }
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

[MessagePackObject]
public sealed class ReferralProductRateWireDto
{
    [Key(0)] public string ProductCode { get; set; } = string.Empty;
    [Key(1)] public string ProductName { get; set; } = string.Empty;
    [Key(2)] public bool Enabled { get; set; }
    [Key(3)] public decimal RebateRatePercent { get; set; }
    [Key(4)] public decimal MinWithdrawAmount { get; set; }
    [Key(5)] public bool WithdrawReviewRequired { get; set; }
}

[MessagePackObject]
public sealed class PlatformReferralSettingsAdminWireDto
{
    [Key(0)] public ReferralProductRateWireDto[] ProductRates { get; set; } = [];
    [Key(1)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class UpdatePlatformReferralSettingsWireCommand
{
    [Key(0)] public ReferralProductRateWireDto[]? ProductRates { get; set; }
}
