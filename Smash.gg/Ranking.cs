using Newtonsoft.Json;

namespace Smash.gg
{
    public class Ranking
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("active")] public bool Active { get; set; }
        [JsonProperty("iterationId")] public int IterationId { get; set; }
        [JsonProperty("sourceId")] public int SourceId { get; set; }
        [JsonProperty("rank")] public int Rank { get; set; }
        [JsonProperty("seriesId")] public int SeriesId { get; set; }
        [JsonProperty("videogameId")] public int VideogameId { get; set; }
        [JsonProperty("externalId")] public object ExternalId { get; set; }
    }
}
