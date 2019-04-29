using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class PlayersOnline
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("vocation")]
        public string Vocation { get; set; }
    }
}