using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class TopAnimeDTO
    {
        [JsonPropertyName("data")]
        public JikanTopAnime? Data { get; set; }
    }
}
