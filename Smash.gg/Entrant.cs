using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Entrant
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("eventId")] public int EventId { get; set; }
        [JsonProperty("participantIds")] public List<int> ParticipantIds { get; set; }
        [JsonProperty("participant1Id")] public object Participant1Id { get; set; }
        [JsonProperty("participant2Id")] public object Participant2Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("finalPlacement")] public int FinalPlacement { get; set; }
        [JsonProperty("defaultSkill")] public int DefaultSkill { get; set; }
        [JsonProperty("skill")] public int? Skill { get; set; }
        [JsonProperty("skillOrder")] public int SkillOrder { get; set; }
        [JsonProperty("unverified")] public bool Unverified { get; set; }
        [JsonProperty("isPlaceholder")] public object IsPlaceholder { get; set; }
        [JsonProperty("expand")] public List<object> Expand { get; set; }
        [JsonProperty("playerIds")] public PlayerIds PlayerIds { get; set; }
        [JsonProperty("initialSeedNum")] public int InitialSeedNum { get; set; }
        [JsonProperty("prefixes")] public Prefixes Prefixes { get; set; }
        [JsonProperty("mutations")] public Mutations Mutations { get; set; }
    }
}