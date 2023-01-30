using System.Text.Json;
using System.Text.Json.Serialization;

namespace Simpler.Models
{
    /// <summary>
    /// Portfolio 모델 클래스
    /// </summary>
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("img")]
        public string Image { get; set; } = string.Empty;

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this);
        }

    }
}
