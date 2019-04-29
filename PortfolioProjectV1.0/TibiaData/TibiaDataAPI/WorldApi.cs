using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using PortfolioProjectV1._0.Models;

namespace PortfolioProjectV1._0.TibiaData.TibiaDataAPI
{
    public class WorldApi
    {
        private string _name;

        public RootObject Worlds { get; set; }

        public WorldApi(string Name)
        {
            _name = Name;
        }

        public RootObject GetDetailsFromApi()
        {
                Worlds = JsonConvert.DeserializeObject<RootObject>(GetJsonFromApi());
                return Worlds;
        }

        public string GetJsonFromApi()
        {
            string jsonString = "";
            if (_name == "Worlds")
            {
                string path = string.Format("https://api.tibiadata.com/v2/worlds.json");
                jsonString = new WebClient().DownloadString(path);
            }
            else
            {
                string path = string.Format("https://api.tibiadata.com/v2/world/{0}.json", _name);
                jsonString = new WebClient().DownloadString(path);
            }


            return jsonString;
        }


    }
}