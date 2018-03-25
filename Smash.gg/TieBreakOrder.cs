using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class TiebreakOrder
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("inputs")] public List<object> Inputs { get; set; }
    }
}
