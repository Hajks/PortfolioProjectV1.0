using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class OtherCharacters
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("world")]
        public string World { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}