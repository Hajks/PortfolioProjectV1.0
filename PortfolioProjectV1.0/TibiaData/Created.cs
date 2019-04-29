using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Created
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("timezone_type")]
        public int TimezoneType { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}