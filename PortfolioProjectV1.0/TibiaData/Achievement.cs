﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Achievement
    {
        [JsonProperty("stars")]
        public int Stars { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}