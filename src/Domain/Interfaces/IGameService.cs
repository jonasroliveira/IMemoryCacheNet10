
using IMemoryCacheCore10.DTOs;

namespace IMemoryCacheCore10.Domain.Interfaces;

public interface IGameService
{
    Task<IReadOnlyList<GameResponseDto>> GetCachedGamesAsync();
}