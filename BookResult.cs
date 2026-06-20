using System.Text.Json.Serialization;

namespace BarcodeAlertApp
{
    public class OpenBdResponse
    {
        [JsonPropertyName("summary")]
        public BookSummary? Summary { get; set; }
    }

    public class BookSummary
    {
        [JsonPropertyName("isbn")]
        public string Isbn { get; set; } = "";

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("author")]
        public string Author { get; set; } = "";

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; } = "";

        [JsonPropertyName("cover")]
        public string Cover { get; set; } = ""; // 表紙画像のURL
    }
}