using Newtonsoft.Json;
using PortfolioProjectV1._0.TibiaData;


namespace PortfolioProjectV1._0.Models
{
    public class RootObject
    {
        [JsonProperty("characters")]
        public Characters Characters { get; set; }

        [JsonProperty("information")]
        public Information Information { get; set; }

        [JsonProperty("world")]
        public World World { get; set; }

        [JsonProperty("worlds")]
        public Worlds Worlds { get; set; }
    }
}