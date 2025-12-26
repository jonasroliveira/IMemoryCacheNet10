
namespace IMemoryCacheCore10.DTOs;
public record GameResponseDto(
    int Id,
    string Title,
    string Thumbnail,
    string ShortDescription,
    string Genre,
    string Platform
);