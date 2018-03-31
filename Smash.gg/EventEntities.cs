using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class EventEntities
    {
        [JsonProperty("event")] public Event Event { get; set; }
        [JsonProperty("groups")] public List<Group> Groups { get; set; }
        [JsonProperty("phase")] public List<Phase> Phase { get; set; }
    }
}
