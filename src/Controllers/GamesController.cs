using IMemoryCacheCore10.Domain.Interfaces;
using IMemoryCacheCore10.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace IMemoryCacheCore10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly IGameService _gameService;

    public GamesController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<GameResponseDto>>> GetAll()
    {
        var games = await _gameService.GetCachedGamesAsync();
        return Ok(games);
    }
}