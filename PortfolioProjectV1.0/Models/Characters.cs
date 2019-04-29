using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PortfolioProjectV1._0.Infrastructure.Interfaces;
using PortfolioProjectV1._0.TibiaData;
using PortfolioProjectV1._0.TibiaData.TibiaDataAPI;

namespace PortfolioProjectV1._0.Models
{
    public class Characters
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("achievements")]
        public Achievement[] Achievements { get; set; }

        [JsonProperty("deaths")]
        [JsonConverter(typeof(SingleOrArrayConverter<Death>))]
        public List<Death> Deaths { get; set; }

        [JsonProperty("account_information")]
        [JsonConverter(typeof(SingleOrArrayConverter<AccountInformation>))]
        public List<AccountInformation> AccountInformation { get; set; }

        [JsonProperty("other_characters")]
        public OtherCharacters[] OtherCharacters { get; set; }


    }
}