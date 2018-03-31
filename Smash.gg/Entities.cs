using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Entities
    {
        [JsonProperty("groups")] public List<Groups> Groups { get; set; }
        [JsonProperty("entrants")] public List<Entrant> Entrants { get; set; }
        [JsonProperty("player")] public List<Player> Player { get; set; }
        [JsonProperty("rankingSeries")] public List<RankingSeries> RankingSeries { get; set; }
        [JsonProperty("rankingIteration")] public List<RankingIteration> RankingIteration { get; set; }
        [JsonProperty("sets")] public List<Set> Sets { get; set; }
        [JsonProperty("stat")] public List<object> Stat { get; set; }
        [JsonProperty("tournament")] public Tournament Tournament { get; set; }
        [JsonProperty("phase")] public List<Phase> Phase { get; set; }
        [JsonProperty("event")] public List<Event> Event { get; set; }
        [JsonProperty("videogame")] public List<Videogame> Videogame { get; set; }
    }
}
