using System.Text.Json.Serialization;
namespace IntegracionApi.DTO
{
    public class JikanTopAnime
    {
        [JsonPropertyName("title")]
        public  string Title { get; set; }
        //[JsonPropertyName("score")]
        //public double score { get; set; }
        [JsonPropertyName("episodes")]
        public int Episodes { get; set; }
        //[JsonPropertyName("year")]
        //public int Year { get; set; }
    }
}
