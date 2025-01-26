using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("webm")]
        public Dictionary<string, string> Webm { get; }

        [JsonProperty("highlight")]
        public bool Highlight { get; set; }

        public Movie()
        {
            this.Webm = new Dictionary<string, string>();
        }

        public override string ToString() => Name;
    }

}
