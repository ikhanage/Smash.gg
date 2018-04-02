using System.Collections.Generic;
using Newtonsoft.Json;

namespace Smash.gg
{
    public class RankingSeries
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("videogameId")] public int VideogameId { get; set; }
        [JsonProperty("sourceId")] public object SourceId { get; set; }
        [JsonProperty("published")] public bool Published { get; set; }
        [JsonProperty("status")] public int Status { get; set; }
        [JsonProperty("locationType")] public int LocationType { get; set; }
        [JsonProperty("locationName")] public object LocationName { get; set; }
        [JsonProperty("locationRadius")] public object LocationRadius { get; set; }
        [JsonProperty("radiusUnit")] public string RadiusUnit { get; set; }
        [JsonProperty("locationId")] public int LocationId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("slug")] public string Slug { get; set; }
        [JsonProperty("description")] public object Description { get; set; }
        [JsonProperty("url")] public object Url { get; set; }
        [JsonProperty("createdAt")] public int CreatedAt { get; set; }
        [JsonProperty("updatedAt")] public int UpdatedAt { get; set; }
        [JsonProperty("createdBy")] public int? CreatedBy { get; set; }
        [JsonProperty("images")] public List<object> Images { get; set; }
        [JsonProperty("expand")] public List<object> Expand { get; set; }
        [JsonProperty("permissionType")] public string PermissionType { get; set; }
    }
}
