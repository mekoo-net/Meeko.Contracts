using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class SchedulerResult
{
    [Key(0)] public int Processed { get; set; }
    [Key(1)] public int Succeeded { get; set; }
    [Key(2)] public int Failed { get; set; }
    [Key(3)] public string? Note { get; set; }
}
