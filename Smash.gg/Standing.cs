using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Standing
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("totalSets")] public int TotalSets { get; set; }
        [JsonProperty("setsPlayed")] public int SetsPlayed { get; set; }
        [JsonProperty("setsWon")] public int SetsWon { get; set; }
        [JsonProperty("gamesPlayed")] public int GamesPlayed { get; set; }
        [JsonProperty("gamesWon")] public int GamesWon { get; set; }
        [JsonProperty("phaseId")] public int PhaseId { get; set; }
        [JsonProperty("phaseGroupId")] public int PhaseGroupId { get; set; }
        [JsonProperty("seedId")] public int SeedId { get; set; }
        [JsonProperty("isBye")] public bool IsBye { get; set; }
        [JsonProperty("entrantId")] public int EntrantId { get; set; }
        [JsonProperty("pendingPlacement")] public int PendingPlacement { get; set; }
        [JsonProperty("placement")] public int Placement { get; set; }
        [JsonProperty("losses")] public List<object> Losses { get; set; }
        [JsonProperty("isProgressionFinal")] public bool IsProgressionFinal { get; set; }
        [JsonProperty("destPhaseId")] public int DestPhaseId { get; set; }
        [JsonProperty("destPhaseGroupId")] public int DestPhaseGroupId { get; set; }
    }
}
