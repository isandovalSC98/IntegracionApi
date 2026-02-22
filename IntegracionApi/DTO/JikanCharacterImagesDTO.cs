using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class JikanCharacterImagesDTO
    {
        [JsonPropertyName("jpg")]
        public JikanImageSetDTO? Jpg { get; set; }

        [JsonPropertyName("webp")]
        public JikanImageSetDTO? Webp { get; set; }
    }
}