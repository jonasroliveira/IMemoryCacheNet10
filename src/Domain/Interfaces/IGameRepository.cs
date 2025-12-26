
using IMemoryCacheCore10.DTOs;

namespace IMemoryCacheCore10.Domain.Interfaces;

public interface IGameRepository
{
    Task<IReadOnlyList<GameResponseDto>> GetAllGamesAsync();
}