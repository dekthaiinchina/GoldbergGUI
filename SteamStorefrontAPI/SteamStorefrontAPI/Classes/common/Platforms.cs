using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Platforms
    {
        [JsonProperty("windows")]
        public bool Windows { get; set; }

        [JsonProperty("mac")]
        public bool Mac { get; set; }

        [JsonProperty("linux")]
        public bool Linux { get; set; }

        public override string ToString()
        {
            return string.Join(",", (Windows ? "Windows" : null), (Linux ? "Linux" : null), (Mac ? "Mac" : null));
        }
    }

}
