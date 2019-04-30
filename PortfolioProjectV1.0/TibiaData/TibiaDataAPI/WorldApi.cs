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

        public RootObject RootObject { get; set; }

        public WorldApi(string Name)
        {
            _name = Name;
            GetDetailsFromApi();
        }

        public RootObject GetDetailsFromApi()
        {
                RootObject = JsonConvert.DeserializeObject<RootObject>(GetJsonFromApi());
                return RootObject;
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

        public List<string> GetPvpServerType()
        {
            List<string> pvpTypesList = new List<string>();

            foreach (AllWorld world in RootObject.Worlds.Allworlds)
            {
                if (pvpTypesList.Contains(world.Name))
                {
                    //doNothing
                }
                else
                {
                    pvpTypesList.Add(world.Name);
                }
            }

            return pvpTypesList;
        }


    }
}