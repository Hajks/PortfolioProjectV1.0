using Newtonsoft.Json;
using PortfolioProjectV1._0.Models;

namespace PortfolioProjectV1._0.TibiaData
{
    public class Data
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("vocation")]
        public string Vocation { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("achievement_points")]
        public int AchievementPoints { get; set; }

        [JsonProperty("world")]
        public string World { get; set; }

        [JsonProperty("residence")]
        public string Residence { get; set; }

        [JsonProperty("house")]
        public House House { get; set; }

        [JsonProperty("guild")]
        public Guild Guild { get; set; }

        [JsonProperty("last_login")]
        public LastLogin[] LastLogin { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("account_status")]
        public string AccountStatus { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}