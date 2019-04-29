using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class OnlineRecord
    {
        [JsonProperty("Players")]
        public int players { get; set; }

        [JsonProperty("date")]
        public Date Date { get; set; }
    }
}