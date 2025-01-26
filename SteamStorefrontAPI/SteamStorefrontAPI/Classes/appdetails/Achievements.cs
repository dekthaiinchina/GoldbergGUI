using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class Achievements
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("highlighted")]
        public List<Highlighted> Highlighted { get; }

        public Achievements()
        {
            this.Highlighted = new List<Highlighted>();
        }
    }
}
