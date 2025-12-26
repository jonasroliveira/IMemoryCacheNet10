namespace IMemoryCacheCore10.Domain.Entities;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
}