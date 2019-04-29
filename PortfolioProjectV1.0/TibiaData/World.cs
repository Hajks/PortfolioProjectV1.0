using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class World
    {
        [JsonProperty("world_information")]
        public WorldInformation WorldInformation { get; set; }

        [JsonProperty("players_online")]
        public PlayersOnline[] PlayersOnline { get; set; }
    }

    public class Worlds
    {
        [JsonProperty("online")]
        public int Online { get; set; }

        [JsonProperty("allworlds")]
        public AllWorld[] Allworlds { get; set; }
    }

    public class AllWorld
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("online")]
        public int Online { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("worldtype")]
        public string Worldtype { get; set; }

        [JsonProperty("additional")]
        public string Additional { get; set; }
    }
}