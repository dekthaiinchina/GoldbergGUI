using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Highlighted
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        public override string ToString() => Name;
    }
}
