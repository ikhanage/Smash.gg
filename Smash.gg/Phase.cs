using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Phase
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("eventId")] public int EventId { get; set; }
        [JsonProperty("typeId")] public int TypeId { get; set; }
        [JsonProperty("phaseOrder")] public int PhaseOrder { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("state")] public int State { get; set; }
        [JsonProperty("pendingSeeds")] public int? PendingSeeds { get; set; }
        [JsonProperty("locked")] public bool Locked { get; set; }
        [JsonProperty("isDefault")] public bool IsDefault { get; set; }
        [JsonProperty("isExhibition")] public bool IsExhibition { get; set; }
        [JsonProperty("tier")] public int Tier { get; set; }
        [JsonProperty("playGF")] public bool PlayGf { get; set; }
        [JsonProperty("loserStartDirection")] public object LoserStartDirection { get; set; }
        [JsonProperty("defaultLoserStartDirection")] public object DefaultLoserStartDirection { get; set; }
        [JsonProperty("poolAvoidanceSetting")] public int PoolAvoidanceSetting { get; set; }
        [JsonProperty("manualPoolAvoidance")] public bool ManualPoolAvoidance { get; set; }
        [JsonProperty("bracketInitializer")] public object BracketInitializer { get; set; }
        [JsonProperty("groupCount")] public int GroupCount { get; set; }
        [JsonProperty("bracketMap")] public List<object> BracketMap { get; set; }
        [JsonProperty("canAutoAssign")] public string CanAutoAssign { get; set; }
        [JsonProperty("groups")] public List<object> Groups { get; set; }
        [JsonProperty("preserveLosses")] public object PreserveLosses { get; set; }
        [JsonProperty("shuffleWinners")] public object ShuffleWinners { get; set; }
        [JsonProperty("shuffleLosers")] public object ShuffleLosers { get; set; }
        [JsonProperty("sequentialOrdering")] public object SequentialOrdering { get; set; }
        [JsonProperty("playFullBrackets")] public object PlayFullBrackets { get; set; }
        [JsonProperty("entrantsIn")] public object EntrantsIn { get; set; }
        [JsonProperty("entrantsOut")] public object EntrantsOut { get; set; }
    }
}
