using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioProjectV1._0.TibiaData
{
    public class WorldInformation
    {
        public string name { get; set; }
        public int players_online { get; set; }
        public OnlineRecord online_record { get; set; }
        public string creation_date { get; set; }
        public string location { get; set; }
        public string pvp_type { get; set; }
        public string[] world_quest_titles { get; set; }
        public string battleye_status { get; set; }
        public string GameWorldType { get; set; }
    }
}