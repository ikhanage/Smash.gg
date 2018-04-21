using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Player
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("gamerTag")] public string GamerTag { get; set; }
        [JsonProperty("prefix")] public string Prefix { get; set; }
        [JsonProperty("twitterHandle")] public string TwitterHandle { get; set; }
        [JsonProperty("twitchStream")] public object TwitchStream { get; set; }
        [JsonProperty("streamMeStream")] public object StreamMeStream { get; set; }
        [JsonProperty("redditUsername")] public object RedditUsername { get; set; }
        [JsonProperty("youtube")] public object Youtube { get; set; }
        [JsonProperty("smashboardsLink")] public object SmashboardsLink { get; set; }
        [JsonProperty("smashboardsUserId")] public object SmashboardsUserId { get; set; }
        [JsonProperty("ssbwikiLink")] public object SsbwikiLink { get; set; }
        [JsonProperty("playerType")] public string PlayerType { get; set; }
        [JsonProperty("rank")] public decimal? Rank { get; set; }
        [JsonProperty("color")] public string Color { get; set; }
        [JsonProperty("nameDisplay")] public string NameDisplay { get; set; }
        [JsonProperty("slug")] public object Slug { get; set; }
        [JsonProperty("state")] public object State { get; set; }
        [JsonProperty("region")] public object Region { get; set; }
        [JsonProperty("country")] public string Country { get; set; }
        [JsonProperty("gamerTagChangedAt")] public int? GamerTagChangedAt { get; set; }
        [JsonProperty("images")] public List<object> Images { get; set; }
        [JsonProperty("entrantId")] public string EntrantId { get; set; }
        [JsonProperty("permissionType")] public string PermissionType { get; set; }
        [JsonProperty("rankings")] public List<Ranking> Rankings { get; set; }
    }
}
