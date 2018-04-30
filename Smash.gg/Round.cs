using Newtonsoft.Json;

namespace Smash.gg
{
    public class Round
    {
        [JsonProperty("durationSeconds")] public object DurationSeconds { get; set; }
        [JsonProperty("startAt")] public object StartAt { get; set; }
        [JsonProperty("bestOf")] public int BestOf { get; set; }
        [JsonProperty("totalGames")] public int TotalGames { get; set; }
        [JsonProperty("setGamesType")] public int SetGamesType { get; set; }
        [JsonProperty("dqTime")] public int DqTime { get; set; }
        [JsonProperty("activateTime")] public object ActivateTime { get; set; }
        [JsonProperty("verifyTime")] public object VerifyTime { get; set; }
        [JsonProperty("verifyTimeMin")] public object VerifyTimeMin { get; set; }
        [JsonProperty("verifyTimeMax")] public object VerifyTimeMax { get; set; }
        [JsonProperty("enforceStartTime")] public bool EnforceStartTime { get; set; }
    }
}
