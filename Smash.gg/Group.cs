using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Group : BaseGroup
    {
        [JsonProperty("expand")] public Dictionary<string, string> Expand { get; set; }
    }
}
