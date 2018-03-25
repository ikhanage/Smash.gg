using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Stats
    {
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("path")] public string Path { get; set; }
        [JsonProperty("config")] public List<object> Config { get; set; }
    }

    public class Tabs
    {
        [JsonProperty("stats")] public Stats Stats { get; set; }
    }
}
