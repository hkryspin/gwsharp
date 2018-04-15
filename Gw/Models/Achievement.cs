using Newtonsoft.Json;

namespace Gw.Models
{
    public class Achievement
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; } // optional

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("requirement")]
        public string requirement { get; set; }

        [JsonProperty("locked_text")]
        public string locked_text { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("flags")]
        public string[] flags { get; set; }

        [JsonProperty("tiers")]
        public Tiers[] tiers { get; set; }

        [JsonProperty("prerequisites")]
        public int[] prerequisites { get; set; } // optional

        [JsonProperty("rewards")]
        public Rewards[] rewards { get; set; } // optional

        [JsonProperty("bits")]
        public Bits[] bits { get; set; } // optional

        [JsonProperty("point_cap")]
        public int point_cap { get; set; } // optional
    }

    public class Tiers
    {
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("points")]
        public int points { get; set; }
    }

    public class Rewards
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }
    }

    public class Bits
    {
        public string type { get; set; }
        public int id { get; set; }
        public string text { get; set; }
    }
}
