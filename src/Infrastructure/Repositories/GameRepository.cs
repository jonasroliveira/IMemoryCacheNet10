using IMemoryCacheCore10.Domain.Interfaces;
using IMemoryCacheCore10.DTOs;

namespace IMemoryCacheCore10.Infrastructure.Repositories;

public class GameRepository : IGameRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    public GameRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IReadOnlyList<GameResponseDto>> GetAllGamesAsync()
    {
        var client = _httpClientFactory.CreateClient("FreeToGame");

        try
        {
            var response = await client.GetFromJsonAsync<List<GameResponseDto>>("games");
            return response ?? new List<GameResponseDto>();
        }
        catch (Exception)
        {
            return new List<GameResponseDto>();
        }
    }
}