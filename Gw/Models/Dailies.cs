using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gw.Models
{
    public partial class Dailies
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("required_access")]
        public List<string> RequiredAccess { get; set; }
    }

    public partial class Level
    {
        [JsonProperty("min")]
        public byte Min { get; set; }

        [JsonProperty("max")]
        public byte Max { get; set; }
    }

    public partial class Dailies
    {
        public static Dictionary<string, List<Dailies>> FromJson(string json) =>
            JsonConvert.DeserializeObject<Dictionary<string, List<Dailies>>>(json, Converter.Settings);
    }

    //public static class Serialize
    //{
    //    public static string ToJson(this Dictionary<string, List<Dailies>> self) =>
    //        JsonConvert.SerializeObject(self, Converter.Settings);
    //}

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
