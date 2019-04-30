using System.Net;
using System.Web.WebPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PortfolioProjectV1._0.Infrastructure.Interfaces;
using PortfolioProjectV1._0.Models;

namespace PortfolioProjectV1._0.TibiaData.TibiaDataAPI
{
    public class CharacterApi : ICharacterProvider
    {
        private string _name;
        public Characters Characters { get; set; }

        public CharacterApi(string Name)
        {
            _name = Name.Replace(" ", "+");
            GetDetailsFromApi();
        }

        public Characters GetDetailsFromApi()
        {
            if (NicknameIsValid())
            {
                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(GetJsonFromApi());
                Characters = rootObject.Characters;
                return Characters;
            }
            else
            {
                return Characters = new Characters() { Error = "Character does not exist." };
            }
        }

        public string GetJsonFromApi()
        {
            string path = string.Format("https://api.tibiadata.com/v2/characters/{0}.json", _name);
            string jsonString = new WebClient().DownloadString(path);

            return jsonString ;
        }

        public bool NicknameIsValid()
        {
            if (_name.IsEmpty())
            {
                return false;
            }
            else
            {
                string jsonString = GetJsonFromApi();

                if (jsonString.Contains("Character does not exist."))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}