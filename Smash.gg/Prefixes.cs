using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Prefixes
    {
        [JsonProperty("prefixes")] public Dictionary<string, string> PrefixesDictionary { get; set; }
    }
}
