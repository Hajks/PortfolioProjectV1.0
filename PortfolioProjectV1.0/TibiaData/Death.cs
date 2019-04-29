using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Death
    {
        [JsonProperty("date")]
        public Date date { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("involed")]
        public Involved[] involved { get; set; }

    }
}