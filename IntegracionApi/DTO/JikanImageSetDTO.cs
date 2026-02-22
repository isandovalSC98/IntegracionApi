using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class JikanImageSetDTO
    {
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("small_image_url")]
        public string? SmallImageUrl { get; set; }
    }
}