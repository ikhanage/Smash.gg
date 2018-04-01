using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class TournamentEntities
    {
        [JsonProperty("tournament")] public Tournament Tournament { get; set; }
        [JsonProperty("phase")] public List<Phase> Phase { get; set; }
        [JsonProperty("groups")] public List<Groups> Groups { get; set; }
        [JsonProperty("event")] public List<Event> Event { get; set; }
        [JsonProperty("videogame")] public List<Videogame> Videogame { get; set; }
    }
}
