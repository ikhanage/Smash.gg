using Newtonsoft.Json;

namespace Smash.gg
{
    public class Group : BaseGroup
    {
        //TODO: One of the test cases uses a list<string>.  Need to work out how to get around that!
        //[JsonProperty("expand")] public Dictionary<string, string> Expand { get; set; }
        [JsonProperty("expand")] public object Expand { get; set; }
    }
}
