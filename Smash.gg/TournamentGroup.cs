using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class TournamentGroup
    {
        [JsonProperty("entities")] public TournamentEntities Entities { get; set; }
        [JsonProperty("result")] public int Result { get; set; }
        [JsonProperty("resultEntity")] public string ResultEntity { get; set; }
        [JsonProperty("actionRecords")] public List<object> ActionRecords { get; set; }
    }
}
