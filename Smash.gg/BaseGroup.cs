using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class BaseGroup
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("phaseId")] public int PhaseId { get; set; }
        [JsonProperty("waveId")] public object WaveId { get; set; }
        [JsonProperty("poolRefId")] public object PoolRefId { get; set; }
        [JsonProperty("groupTypeId")] public int GroupTypeId { get; set; }
        [JsonProperty("title")] public object Title { get; set; }
        [JsonProperty("identifier")] public string Identifier { get; set; }
        [JsonProperty("displayIdentifier")] public string DisplayIdentifier { get; set; }
        [JsonProperty("state")] public int State { get; set; }
        [JsonProperty("tiebreakOrder")] public List<TiebreakOrder> TiebreakOrder { get; set; }
        [JsonProperty("tiebreaks")] public object Tiebreaks { get; set; }
        [JsonProperty("bestOf")] public object BestOf { get; set; }
        [JsonProperty("setsOnDeck")] public int SetsOnDeck { get; set; }
        [JsonProperty("rematchSeconds")] public int RematchSeconds { get; set; }
        [JsonProperty("finalized")] public bool Finalized { get; set; }
        [JsonProperty("winnersTargetPhaseId")] public int? WinnersTargetPhaseId { get; set; }
        [JsonProperty("numProgressing")] public int NumProgressing { get; set; }
        [JsonProperty("losersTargetPhaseId")] public object LosersTargetPhaseId { get; set; }
        [JsonProperty("startAt")] public object StartAt { get; set; }
        [JsonProperty("startedAt")] public object StartedAt { get; set; }
        [JsonProperty("seeds")] public List<object> Seeds { get; set; }
        [JsonProperty("sets")] public List<object> Sets { get; set; }
        [JsonProperty("rounds")] public List<object> Rounds { get; set; }
        [JsonProperty("numRounds")] public object NumRounds { get; set; }
        [JsonProperty("firstRoundTime")] public object FirstRoundTime { get; set; }
        [JsonProperty("canAutoAssign")] public bool CanAutoAssign { get; set; }
        [JsonProperty("autoAssigning")] public bool AutoAssigning { get; set; }
        [JsonProperty("runOnce")] public bool RunOnce { get; set; }
        [JsonProperty("callMatches")] public bool CallMatches { get; set; }
        [JsonProperty("applyAll")] public bool ApplyAll { get; set; }
        [JsonProperty("pointsPerMatchWin")] public int? PointsPerMatchWin { get; set; }
        [JsonProperty("pointsPerGameWin")] public int? PointsPerGameWin { get; set; }
        [JsonProperty("pointsPerBye")] public int? PointsPerBye { get; set; }
        [JsonProperty("matchmakingEnabled")] public bool MatchmakingEnabled { get; set; }
        [JsonProperty("scheduleId")] public int? ScheduleId { get; set; }
        [JsonProperty("hasSets")] public bool HasSets { get; set; }
        [JsonProperty("hasCustomWinnerByes")] public bool HasCustomWinnerByes { get; set; }
        [JsonProperty("percentageComplete")] public string PercentageComplete { get; set; }
    }
}
