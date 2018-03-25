using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Mutations
    {
        [JsonProperty("players")] public Dictionary<string, Player> Players { get; set; }
        [JsonProperty("participants")] public Dictionary<int, Participant> Participants { get; set; }
    }
}