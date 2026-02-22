using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class AnimeCharactersItemDTO
    {
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        [JsonPropertyName("character")]
        public JikanCharacterDTO? Character { get; set; }
    }
}
