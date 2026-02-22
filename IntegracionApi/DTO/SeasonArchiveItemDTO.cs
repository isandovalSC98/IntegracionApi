using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class SeasonArchiveItemDTO
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("seasons")]
        public List<string> Seasons { get; set; } = new();
    }
}
