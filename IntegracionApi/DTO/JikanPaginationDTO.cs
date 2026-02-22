using System.Text.Json.Serialization;

namespace IntegracionApi.DTO
{
    public class JikanPaginationDTO
    {
        [JsonPropertyName("last_visible_page")]
        public int LastVisiblePage { get; set; }

        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
