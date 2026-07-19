using MagicOnion;
using Meeko.Contracts.Tavern.LlmMedia.Dtos;

namespace Meeko.Contracts.Tavern.LlmMedia;

/// <summary>
/// Tavern.Gateway → Meeko.Tavern：为 LLM 模型解析媒体引用，换取临时可读 URL。
/// </summary>
public interface ITavernLlmMediaService : IService<ITavernLlmMediaService>
{
    UnaryResult<string?> SignMediaGetAsync(SignMediaGetQuery query);
}
