using System.Text.Json.Serialization;

namespace app.models // Matches your folder name
{
    public class NoaaPointResponse
    {
        [JsonPropertyName("properties")]
        public PointProperties Properties { get; set; }
    }

    public class PointProperties
    {
        [JsonPropertyName("forecast")]
        public string ForecastUrl { get; set; }

        [JsonPropertyName("relativeLocation")]
        public RelativeLocationContainer RelativeLocation { get; set; }
    }

    public class RelativeLocationContainer
    {
        [JsonPropertyName("properties")]
        public CityStateData Data { get; set; }
    }

    public class CityStateData
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
