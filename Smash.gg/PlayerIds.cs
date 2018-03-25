using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class PlayerIds
    {
        [JsonProperty("playerIds")] public Dictionary<string, int> PlayerIdsDictionary { get; set; }
        [JsonProperty("ParticipantId1")] public int ParticipantId1 { get; set; }
        [JsonProperty("ParticipantId2")] public int? ParticipantId2 { get; set; }
        [JsonProperty("WinnerId")] public int? WinnerId { get; set; }
        [JsonProperty("LoserId")] public int? LoserId { get; set; }
    }
}
