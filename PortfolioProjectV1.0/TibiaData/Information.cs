using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Information
    {
        [JsonProperty("api_version")]
        public int ApiVersion { get; set; }

        [JsonProperty("execution_time")]
        public float ExecutionTime { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}