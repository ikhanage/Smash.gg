using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class GroupTournament : BaseGroup
    {
        [JsonProperty("expand")] public List<string> Expand { get; set; }
    }
}
