using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Publishing
    {
        [JsonProperty("publish")] public bool Publish { get; set; }
        [JsonProperty("registration")] public bool Registration { get; set; }
        [JsonProperty("attendees")] public bool Attendees { get; set; }
        [JsonProperty("seeding")] public object Seeding { get; set; }
        [JsonProperty("bracket")] public object Bracket { get; set; }
        [JsonProperty("feedback")] public List<object> Feedback { get; set; }
        [JsonProperty("live")] public bool Live { get; set; }
        [JsonProperty("fantasy")] public bool Fantasy { get; set; }
        [JsonProperty("testmode")] public bool Testmode { get; set; }
        [JsonProperty("pools_ordering")] public string PoolsOrdering { get; set; }
        [JsonProperty("hide_spectators")] public bool HideSpectators { get; set; }
    }
}
