using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class PhaseGroupEntities
    {
        [JsonProperty("groups")] public Group BaseGroup { get; set; }
        [JsonProperty("entrants")] public List<Entrant> Entrants { get; set; }
        [JsonProperty("player")] public List<Player> Player { get; set; }
        [JsonProperty("rankingSeries")] public List<RankingSeries> RankingSeries { get; set; }
        [JsonProperty("rankingIteration")] public List<RankingIteration> RankingIteration { get; set; }
        [JsonProperty("sets")] public List<Set> Sets { get; set; }
        [JsonProperty("stat")] public List<object> Stat { get; set; }
        [JsonProperty("standings")] public List<Standing> Standings { get; set; }
    }
}
