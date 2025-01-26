using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class ReleaseDate
    {
        [JsonProperty("coming_soon")]
        public bool ComingSoon { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        public override string ToString() => string.IsNullOrWhiteSpace(Date) ? "Coming Soon" : Date;
    }
}
