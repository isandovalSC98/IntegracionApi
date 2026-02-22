using IntegracionApi.DTO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace IntegracionApi.Servicios
{
    public class Servicio_API : IServicio_API
    {

        private readonly HttpClient _httpClient;

        public Servicio_API(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SeasonArchiveItemDTO>> ObtenerSeason(CancellationToken ct = default)
        {
            var url = await _httpClient.GetFromJsonAsync<JikanResponseDTO<List<SeasonArchiveItemDTO>>>("seasons", cancellationToken : ct);

            return url?.Data ?? new List<SeasonArchiveItemDTO>();
        }

        public async Task<List<AnimeCharactersItemDTO>> ObtenerPersonajes(int animeId, CancellationToken ct = default)
        {
            var url = await _httpClient.GetFromJsonAsync<JikanResponseDTO<List<AnimeCharactersItemDTO>>>($"anime/{animeId}/characters", cancellationToken : ct);
            return url?.Data ?? new List<AnimeCharactersItemDTO>();
        }
    }
}
