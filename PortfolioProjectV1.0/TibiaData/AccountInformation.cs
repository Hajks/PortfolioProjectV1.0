using Newtonsoft.Json;

namespace PortfolioProjectV1._0.TibiaData
{
    public class AccountInformation
    {
        [JsonProperty("loyalty_title")]
        public string LoyaltyTitle { get; set; }

        [JsonProperty("created")]
        public Created Created { get; set; }
    }
}