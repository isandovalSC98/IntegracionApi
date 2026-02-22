using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class JikanResponseDTO<T>
    {
        [JsonPropertyName("pagination")]
        public JikanPaginationDTO? Pagination { get; set; }

        [JsonPropertyName("data")]
        public T? Data { get; set; }
    }
}
