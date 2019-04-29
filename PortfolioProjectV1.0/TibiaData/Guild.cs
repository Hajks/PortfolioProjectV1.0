using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Guild
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
    }
}