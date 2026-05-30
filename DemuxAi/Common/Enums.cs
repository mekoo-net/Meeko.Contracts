namespace Meeko.Contracts.DemuxAi.Common;

public enum AiTokenStatus
{
    Active = 1,
    Disabled = 2,
    Expired = 3,
    Exhausted = 4,
}

public enum ReservationStatus
{
    Active = 1,
    Committed = 2,
    Cancelled = 3,
    Expired = 4,
}

public enum AiVendorStatus
{
    Active = 1,
    Disabled = 2,
}

public enum AiModelStatus
{
    Active = 1,
    Disabled = 2,
    Hidden = 3,
}

public enum AiModelEndpointType
{
    Chat = 1,
    Completion = 2,
    Embedding = 3,
    Image = 4,
    Audio = 5,
    Rerank = 6,
    Realtime = 7,
    Moderation = 8,
    Responses = 9,
    Video = 10,
    Midjourney = 11,
    Suno = 12,
}

public enum AiUsageStatus
{
    Success = 1,
    Failure = 2,
    Cancelled = 3,
}

public enum RedemptionStatus
{
    Unused = 1,
    Used = 2,
    Disabled = 3,
    Expired = 4,
}

public enum LlmBackendStatus
{
    Active = 1,
    Disabled = 2,
}
