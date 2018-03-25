using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Set
    {
        [JsonProperty("id")]  public int Id { get; set; }
        [JsonProperty("eventId")]  public int EventId { get; set; }
        [JsonProperty("phaseGroupId")]  public int PhaseGroupId { get; set; }
        [JsonProperty("stationId")]  public object StationId { get; set; }
        [JsonProperty("streamId")]  public object StreamId { get; set; }
        [JsonProperty("entrant1Id")]  public int Entrant1Id { get; set; }
        [JsonProperty("entrant2Id")]  public int Entrant2Id { get; set; }
        [JsonProperty("winnerId")]  public int WinnerId { get; set; }
        [JsonProperty("loserId")]  public int LoserId { get; set; }
        [JsonProperty("bracketId")]  public string BracketId { get; set; }
        [JsonProperty("entrant1PrereqType")]  public string Entrant1PrereqType { get; set; }
        [JsonProperty("entrant1PrereqId")]  public int Entrant1PrereqId { get; set; }
        [JsonProperty("entrant1PrereqCondition")]  public object Entrant1PrereqCondition { get; set; }
        [JsonProperty("entrant2PrereqType")]  public string Entrant2PrereqType { get; set; }
        [JsonProperty("entrant2PrereqId")]  public int Entrant2PrereqId { get; set; }
        [JsonProperty("entrant2PrereqCondition")]  public object Entrant2PrereqCondition { get; set; }
        [JsonProperty("wProgressionSeedId")]  public object WProgressionSeedId { get; set; }
        [JsonProperty("lProgressionSeedId")]  public object LProgressionSeedId { get; set; }
        [JsonProperty("wPlacement")]  public object WPlacement { get; set; }
        [JsonProperty("lPlacement")]  public object LPlacement { get; set; }
        [JsonProperty("wOverallPlacement")]  public object WOverallPlacement { get; set; }
        [JsonProperty("lOverallPlacement")]  public object LOverallPlacement { get; set; }
        [JsonProperty("lEligiblePhaseId")]  public object LEligiblePhaseId { get; set; }
        [JsonProperty("wEligiblePhaseId")]  public object WEligiblePhaseId { get; set; }
        [JsonProperty("unreachable")]  public bool Unreachable { get; set; }
        [JsonProperty("isTiebreak")]  public bool IsTiebreak { get; set; }
        [JsonProperty("type")]  public int Type { get; set; }
        [JsonProperty("crewPlayerCount")]  public object CrewPlayerCount { get; set; }
        [JsonProperty("identifier")]  public string Identifier { get; set; }
        [JsonProperty("round")]  public int Round { get; set; }
        [JsonProperty("state")]  public int State { get; set; }
        [JsonProperty("entrant1Score")]  public int Entrant1Score { get; set; }
        [JsonProperty("entrant2Score")]  public int Entrant2Score { get; set; }
        [JsonProperty("bestOf")]  public int BestOf { get; set; }
        [JsonProperty("totalGames")]  public int TotalGames { get; set; }
        [JsonProperty("setGamesType")]  public int SetGamesType { get; set; }
        [JsonProperty("isLast")]  public bool IsLast { get; set; }
        [JsonProperty("isGF")]  public bool IsGf { get; set; }
        [JsonProperty("hasPlaceholder")]  public bool HasPlaceholder { get; set; }
        [JsonProperty("entrant1Present")]  public bool Entrant1Present { get; set; }
        [JsonProperty("entrant2Present")]  public bool Entrant2Present { get; set; }
        [JsonProperty("adminViewedBy")]  public object AdminViewedBy { get; set; }
        [JsonProperty("adminMessagedBy")]  public object AdminMessagedBy { get; set; }
        [JsonProperty("tasksPruned")]  public object TasksPruned { get; set; }
        [JsonProperty("subState")]  public List<object> SubState { get; set; }
        [JsonProperty("modRequestedBy")]  public object ModRequestedBy { get; set; }
        [JsonProperty("modRequestedAt")]  public object ModRequestedAt { get; set; }
        [JsonProperty("vodUrl")]  public object VodUrl { get; set; }
        [JsonProperty("fbUrl")]  public object FbUrl { get; set; }
        [JsonProperty("smashggUrl")]  public object SmashggUrl { get; set; }
        [JsonProperty("durationSeconds")]  public object DurationSeconds { get; set; }
        [JsonProperty("createdAt")]  public int CreatedAt { get; set; }
        [JsonProperty("updatedAt")]  public int UpdatedAt { get; set; }
        [JsonProperty("updatedAtMicro")]  public double UpdatedAtMicro { get; set; }
        [JsonProperty("startAt")]  public object StartAt { get; set; }
        [JsonProperty("startedAt")]  public object StartedAt { get; set; }
        [JsonProperty("completedAt")]  public int CompletedAt { get; set; }
        [JsonProperty("adminViewedAt")]  public object AdminViewedAt { get; set; }
        [JsonProperty("adminMessagedAt")]  public object AdminMessagedAt { get; set; }
        [JsonProperty("slots")]  public List<object> Slots { get; set; }
        [JsonProperty("progressionPlacement")]  public object ProgressionPlacement { get; set; }
        [JsonProperty("progressionCount")]  public object ProgressionCount { get; set; }
        [JsonProperty("games")]  public List<object> Games { get; set; }
        [JsonProperty("videogameId")]  public int VideogameId { get; set; }
        [JsonProperty("eventType")]  public int EventType { get; set; }
        [JsonProperty("images")]  public List<object> Images { get; set; }
        [JsonProperty("expand")]  public List<string> Expand { get; set; }
        [JsonProperty("displayRound")]  public int DisplayRound { get; set; }
        [JsonProperty("originalRound")]  public int OriginalRound { get; set; }
        [JsonProperty("fullRoundText")]  public string FullRoundText { get; set; }
        [JsonProperty("midRoundText")]  public string MidRoundText { get; set; }
        [JsonProperty("shortRoundText")]  public string ShortRoundText { get; set; }
        [JsonProperty("roundDivision")]  public object RoundDivision { get; set; }
    }
}
