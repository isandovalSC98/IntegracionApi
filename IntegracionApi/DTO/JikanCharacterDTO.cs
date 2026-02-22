using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class JikanCharacterDTO
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        // Opcional: imágenes
        [JsonPropertyName("images")]
        public JikanCharacterImagesDTO? Images { get; set; }
    }
}