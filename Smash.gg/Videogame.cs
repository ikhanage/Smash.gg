using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class Videogame
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("abbrev")] public string Abbrev { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("displayName")] public string DisplayName { get; set; }
        [JsonProperty("minPerEntry")] public int? MinPerEntry { get; set; }
        [JsonProperty("maxPerEntry")] public int? MaxPerEntry { get; set; }
        [JsonProperty("approved")] public bool Approved { get; set; }
        [JsonProperty("slug")] public string Slug { get; set; }
        [JsonProperty("isCardGame")] public object IsCardGame { get; set; }
        [JsonProperty("characterTerm")] public object CharacterTerm { get; set; }
        [JsonProperty("stageTerm")] public object StageTerm { get; set; }
        [JsonProperty("gameTerm")] public object GameTerm { get; set; }
        [JsonProperty("initialStocks")] public object InitialStocks { get; set; }
        [JsonProperty("images")] public List<Image> Images { get; set; }
        [JsonProperty("enabled")] public string Enabled { get; set; }
    }
}
