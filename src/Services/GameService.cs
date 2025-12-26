using IMemoryCacheCore10.Domain.Interfaces;
using IMemoryCacheCore10.DTOs;
using Microsoft.Extensions.Caching.Memory;

public class GameService : IGameService
{
    private const string GamesCacheKey = "GamesList_Key";

    private readonly IGameRepository _repository;
    private readonly IMemoryCache _cache;

    public GameService(IGameRepository repository, IMemoryCache cache)
    {
        _repository = repository;
        _cache = cache;
    }

    public async Task<IReadOnlyList<GameResponseDto>> GetCachedGamesAsync()
    {
        return await _cache.GetOrCreateAsync(
            GamesCacheKey,
            async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                entry.SlidingExpiration = TimeSpan.FromMinutes(20);
                Console.WriteLine("20 minutos se passaram ou o cache não existia. Buscando os dados da fonte...");

                return await _repository.GetAllGamesAsync()
                       ?? new List<GameResponseDto>();
            }
        ) ?? Array.Empty<GameResponseDto>();
    }
}
