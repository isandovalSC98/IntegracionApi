using IntegracionApi.DTO;
namespace IntegracionApi.Servicios
{
    public interface IServicio_API
    {
        Task<List<SeasonArchiveItemDTO>> ObtenerSeason(CancellationToken ct = default);

        Task<List<AnimeCharactersItemDTO>> ObtenerPersonajes(int animeId, CancellationToken ct = default);

        Task<List<TopAnimeDTO>> ObtenerTopAnime(CancellationToken ct = default);
    }
}
