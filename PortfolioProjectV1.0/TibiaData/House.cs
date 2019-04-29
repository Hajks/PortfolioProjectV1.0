using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class House
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("town")]
        public string Town { get; set; }
        [JsonProperty("paid")]
        public string Paid { get; set; }
        [JsonProperty("world")]
        public string World { get; set; }
        [JsonProperty("houseid")]
        public int HouseId { get; set; }
    }
}