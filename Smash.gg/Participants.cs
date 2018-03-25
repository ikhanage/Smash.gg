using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Participants
    {
        [JsonProperty("participants")] public Dictionary<int, Participant> ParticipantDictionary { get; set; }
    }

    public class Participant
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("gamerTag")] public string GamerTag { get; set; }
        [JsonProperty("prefix")] public object Prefix { get; set; }
        [JsonProperty("playerId")] public int PlayerId { get; set; }
    }
}
