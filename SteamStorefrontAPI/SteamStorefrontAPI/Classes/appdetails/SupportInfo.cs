using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class SupportInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
