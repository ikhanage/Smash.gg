using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Event
    {
        [JsonProperty("id")]  public int Id { get; set; }
        [JsonProperty("tournamentId")]  public int TournamentId { get; set; }
        [JsonProperty("state")]  public int State { get; set; }
        [JsonProperty("progressMeter")]  public int ProgressMeter { get; set; }
        [JsonProperty("videogameId")]  public int VideogameId { get; set; }
        [JsonProperty("name")]  public string Name { get; set; }
        [JsonProperty("description")]  public object Description { get; set; }
        [JsonProperty("slug")]  public string Slug { get; set; }
        [JsonProperty("entryFee")]  public int EntryFee { get; set; }
        [JsonProperty("entryCap")]  public object EntryCap { get; set; }
        [JsonProperty("entrantSizeMin")]  public int EntrantSizeMin { get; set; }
        [JsonProperty("entrantSizeMax")]  public int EntrantSizeMax { get; set; }
        [JsonProperty("requiredCheckinNum")]  public int RequiredCheckinNum { get; set; }
        [JsonProperty("teamNameAllowed")]  public bool TeamNameAllowed { get; set; }
        [JsonProperty("teamManagementDeadline")]  public object TeamManagementDeadline { get; set; }
        [JsonProperty("allowAutoReport")]  public bool AllowAutoReport { get; set; }
        [JsonProperty("tmgEventType")]  public object TmgEventType { get; set; }
        [JsonProperty("templateId")]  public object TemplateId { get; set; }
        [JsonProperty("gameName")]  public object GameName { get; set; }
        [JsonProperty("playersPerEntry")]  public object PlayersPerEntry { get; set; }
        [JsonProperty("exhibition")]  public object Exhibition { get; set; }
        [JsonProperty("networkIds")]  public object NetworkIds { get; set; }
        [JsonProperty("platformIds")]  public List<string> PlatformIds { get; set; }
        [JsonProperty("version")]  public object Version { get; set; }
        [JsonProperty("type")]  public int Type { get; set; }
        [JsonProperty("formatType")]  public int FormatType { get; set; }
        [JsonProperty("teamsFormat")]  public int TeamsFormat { get; set; }
        [JsonProperty("entrantMode")]  public int EntrantMode { get; set; }
        [JsonProperty("private")]  public bool Private { get; set; }
        [JsonProperty("isOnline")]  public bool IsOnline { get; set; }
        [JsonProperty("isOnline")]  public bool HasTasks { get; set; }
        [JsonProperty("hasDecks")]  public bool HasDecks { get; set; }
        [JsonProperty("enableSlippi")]  public bool EnableSlippi { get; set; }
        [JsonProperty("hasMatchmaking")]  public bool HasMatchmaking { get; set; }
        [JsonProperty("isPlaceholder")]  public bool IsPlaceholder { get; set; }
        [JsonProperty("checkInEnabled")]  public bool CheckInEnabled { get; set; }
        [JsonProperty("checkInDuration")]  public int CheckInDuration { get; set; }
        [JsonProperty("checkInBuffer")]  public int CheckInBuffer { get; set; }
        [JsonProperty("deadlineAction")]  public object DeadlineAction { get; set; }
        [JsonProperty("startAt")]  public int StartAt { get; set; }
        [JsonProperty("endAt")]  public int EndAt { get; set; }
        [JsonProperty("startedAt")]  public object StartedAt { get; set; }
        [JsonProperty("completedAt")]  public object CompletedAt { get; set; }
        [JsonProperty("projectionMode")]  public object ProjectionMode { get; set; }
        [JsonProperty("rulesetId")]  public object RulesetId { get; set; }
        [JsonProperty("requiresVerification")]  public object RequiresVerification { get; set; }
        [JsonProperty("pageConfig")]  public PageConfig PageConfig { get; set; }
        [JsonProperty("gameModeConfig")]  public List<object> GameModeConfig { get; set; }
        [JsonProperty("rulesetSettings")]  public List<object> RulesetSettings { get; set; }
        [JsonProperty("deckSubmissionDeadline")]  public object DeckSubmissionDeadline { get; set; }
        [JsonProperty("deckDeadlineHandled")]  public bool DeckDeadlineHandled { get; set; }
        [JsonProperty("stations")]  public List<object> Stations { get; set; }
        [JsonProperty("streams")]  public List<object> Streams { get; set; }
        [JsonProperty("waves")]  public List<object> Waves { get; set; }
        [JsonProperty("publishing")]  public List<object> Publishing { get; set; }
        [JsonProperty("images")]  public List<object> Images { get; set; }
        [JsonProperty("scheduleId")]  public int ScheduleId { get; set; }
        [JsonProperty("platform")]  public object Platform { get; set; }
        [JsonProperty("expand")]  public List<object> Expand { get; set; }
        [JsonProperty("typeDisplayStr")]  public string TypeDisplayStr { get; set; }
    }
}
