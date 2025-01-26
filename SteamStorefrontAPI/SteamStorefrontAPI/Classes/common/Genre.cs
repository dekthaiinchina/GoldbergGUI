using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Genre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString() => Description;
    }

}
