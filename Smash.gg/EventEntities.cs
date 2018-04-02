using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class EventEntities
    {
        [JsonProperty("event")] public Event Event { get; set; }
        [JsonProperty("groups")] public List<GroupTournament> Groups { get; set; }
        [JsonProperty("phase")] public List<Phase> Phase { get; set; }
    }
}
