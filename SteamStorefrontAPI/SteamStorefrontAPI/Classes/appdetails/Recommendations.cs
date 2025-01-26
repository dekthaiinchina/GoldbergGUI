using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Recommendations
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        public override string ToString() => Total.ToString();
    }
}
