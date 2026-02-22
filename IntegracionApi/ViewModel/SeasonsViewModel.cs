using System.Text.Json.Serialization;
using IntegracionApi.DTO;

namespace IntegracionApi.ViewModel
{
    public class SeasonsViewModel
    {
        public List<SeasonArchiveItemDTO> Items { get; set; } = new();
    }
}
