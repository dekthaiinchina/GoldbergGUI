using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public class FullGamepadSupport
    {
        [JsonProperty("full_gamepad")]
        public bool FullGamepad { get; set; }

        public override string ToString() => FullGamepad.ToString();
    }
}
