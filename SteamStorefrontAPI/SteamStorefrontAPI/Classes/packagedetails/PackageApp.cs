using System;
using Newtonsoft.Json;

namespace SteamStorefrontAPI.Classes
{
    public partial class PackageApp : IEquatable<PackageApp>
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public bool Equals(PackageApp other)
        {
            if (other == null)
                return false;

            if (this.Id == other.Id)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            PackageApp personObj = obj as PackageApp;
            if (personObj == null)
                return false;
            else
                return Equals(personObj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
