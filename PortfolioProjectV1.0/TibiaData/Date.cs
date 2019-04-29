using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Date
    {
        [JsonProperty("date")]
        public string ObjectDate { get; set; }

        [JsonProperty("timezone_type")]
        public int TimezoneType { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}